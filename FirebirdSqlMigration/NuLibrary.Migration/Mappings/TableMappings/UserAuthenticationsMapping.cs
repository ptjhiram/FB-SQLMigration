﻿using Newtonsoft.Json;
using NuLibrary.Migration.SQLDatabase.EF;
using NuLibrary.Migration.SQLDatabase.SQLHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuLibrary.Migration.Mappings.TableMappings
{
    public class UserAuthenticationsMapping
    {
        AspnetDbHelpers aHelper = new AspnetDbHelpers();
        NumedicsGlobalHelpers nHelper = new NumedicsGlobalHelpers();

        public void CreateUserAuthenticationMapping()
        {
            try
            {
                foreach (var adUser in aHelper.GetAllUsers())
                {
                    aspnet_Membership member;
                    aspnet_Users aspUser;
                    UserAuthentication uAuth = null;
                    Guid appId = nHelper.GetApplicationId("Diabetes Partner");
                    bool isAdmin = (adUser.CliniProID.ToLower() == "admin") ? true : false;
                    bool isAdminSiteUser = false;


                    if (isAdmin)
                    {
                        string corp = aHelper.GetCorporationName(adUser.CPSiteId);

                        switch (corp)
                        {
                            case "Insulet":
                                appId = nHelper.GetApplicationId("OmniPod Partner");
                                break;
                            case "CliniProWeb":
                                appId = nHelper.GetApplicationId("CliniPro-Web");
                                break;
                            case "NuMedics":
                            default:
                                appId = nHelper.GetApplicationId("Administration");
                                isAdminSiteUser = true;
                                break;
                        } 
                    }

                    member = aHelper.GetMembershipInfo(adUser.UserId);
                    aspUser = aHelper.GetAspUserInfo(adUser.UserId);

                    uAuth = new UserAuthentication
                    {
                        ApplicationId = appId,
                        UserId = adUser.UserId,
                        Username = aspUser.UserName,
                        Password = member.Password,
                        PasswordQuestion = member.PasswordQuestion,
                        PasswordAnswer = member.PasswordAnswer,
                        PasswordAnswerFailureCount = member.FailedPasswordAnswerAttemptCount,
                        PasswordFailureCount = member.FailedPasswordAttemptCount,
                        LastActivityDate = aspUser.LastActivityDate,
                        LastLockOutDate = member.LastLockoutDate,
                        IsApproved = member.IsApproved,
                        IsLockedOut = member.IsLockedOut,
                        IsTempPassword = member.IsTemp,
                        IsloggedIn = false
                    };

                    var user = new User
                    {
                        UserId = adUser.UserId,
                        UserType = (isAdmin) ? (int)UserType.Clinician : (int)UserType.Patient,
                        CreationDate = member.CreateDate
                    };

                    if (isAdminSiteUser)
                    {
                        user.UserType = (int)UserType.Admin;
                    }

                    user.UserAuthentications.Add(uAuth);

                    if (CanAddToContext(user.UserId))
                    {
                        TransactionManager.DatabaseContext.Users.Add(user); 
                    }
                    else
                    {
                        TransactionManager.FailedMappingCollection
                            .Add(new FailedMappings
                            {
                                Tablename = "Users",
                                ObjectType = typeof(User),
                                JsonSerializedObject = JsonConvert.SerializeObject(user),
                                FailedReason = "User already exist in database."
                            });
                    }
                }

                TransactionManager.DatabaseContext.SaveChanges();
            }
            catch (Exception e)
            {
                throw;
            }

        }

        private bool CanAddToContext(Guid userId)
        {
            using (var ctx = new NuMedicsGlobalEntities())
            {
                return (ctx.Users.Any(a => a.UserId == userId)) ? false : true;
            }
        }
    }
}