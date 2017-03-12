﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NuLibrary.Migration.SqlValidations;
using NuLibrary.Migration.Mappings.TableMappings;
using NuLibrary.Migration.Mappings.InMemoryMappings;
using NuLibrary.Migration.Interfaces;
using NuLibrary.Migration.SQLDatabase.EF;

namespace NuLibrary.Migration.Mappings
{
    /// <summary>
    /// Manages the execution of the migration.
    /// </summary>
    public class MappingExecutionManager
    {
        /// <summary>
        /// Stores collection of mapping instances
        /// </summary>
        public Dictionary<int, KeyValuePair<Type, IContextHandler>> mapInstances = new Dictionary<int, KeyValuePair<Type, IContextHandler>>();

        public bool MappingsCompleted = false;

        /// <summary>
        /// Constructor that initializes mapping instances.
        /// </summary>
        public MappingExecutionManager()
        {
            InitializeMappings();
        }

        /// <summary>
        /// Initializes mapping instances and adds them to the dictionary
        /// </summary>
        private void InitializeMappings()
        {
            mapInstances.Add(0, new KeyValuePair<Type, IContextHandler>(typeof(InstitutionMapping), new InstitutionMapping()));
            mapInstances.Add(1, new KeyValuePair<Type, IContextHandler>(typeof(UserAuthenticationsMapping), new UserAuthenticationsMapping()));
            mapInstances.Add(2, new KeyValuePair<Type, IContextHandler>(typeof(ClinicianMapping), new ClinicianMapping()));
            mapInstances.Add(3, new KeyValuePair<Type, IContextHandler>(typeof(PatientsMapping), new PatientsMapping()));
            mapInstances.Add(4, new KeyValuePair<Type, IContextHandler>(typeof(PatientPhoneNumbersMapping), new PatientPhoneNumbersMapping()));
            mapInstances.Add(5, new KeyValuePair<Type, IContextHandler>(typeof(InsuranceCompaniesMapping), new InsuranceCompaniesMapping()));
            mapInstances.Add(6, new KeyValuePair<Type, IContextHandler>(typeof(InsurancePlansMapping), new InsurancePlansMapping()));
            mapInstances.Add(7, new KeyValuePair<Type, IContextHandler>(typeof(DMDataMapping), new DMDataMapping()));
            mapInstances.Add(8, new KeyValuePair<Type, IContextHandler>(typeof(TimeSlotsMapping), new TimeSlotsMapping()));
            mapInstances.Add(9, new KeyValuePair<Type, IContextHandler>(typeof(DeviceMeterReadingHeaderMapping), new DeviceMeterReadingHeaderMapping()));
            mapInstances.Add(10, new KeyValuePair<Type, IContextHandler>(typeof(SubscriptionsMapping), new SubscriptionsMapping()));
            mapInstances.Add(11, new KeyValuePair<Type, IContextHandler>(typeof(MeterReadingMapping), new MeterReadingMapping()));
            //mapInstances.Add(12, new KeyValuePair<Type, IContextHandler>(typeof(PumpSettingMapping), new PumpSettingMapping()));
        }

        /// <summary>
        /// Validates all lookup tables.
        /// Begins execution of mapping sequence
        /// </summary>
        public void BeginExecution()
        {
            var vt = new ValidateTables();
            var validDict = vt.ValidateAll();

            CreateMappings();
        }

        /// <summary>
        /// Creates firebird to sql mappings in paralell
        /// </summary>
        private void CreateMappings()
        {
            // this set of task must execute first to populate in-memory objects used by subsequent task list.
            var taskSetA = new List<Task> { 
                Task.Run(() =>
                {
                    var instance = (InstitutionMapping)mapInstances[0].Value;
                    instance.CreateInstitutionMapping();
                }),
                Task.Run(() =>
                {
                    var instance = (UserAuthenticationsMapping)mapInstances[1].Value;
                    instance.CreateUserAuthenticationMapping();
                }),
                Task.Run(() =>
                {
                    var instance = (ClinicianMapping)mapInstances[2].Value;
                    instance.CreateClinicianMapping();
                }),
                Task.Run(() =>
                {
                    var instance = (PatientsMapping)mapInstances[3].Value;
                    instance.CreatePatientMapping();
                }),
                Task.Run(() =>
                {
                    var instance = new NuLicenseMapping();
                    instance.CreateNuLicenseMapping();
                })
            };

            Task.WhenAll(taskSetA).ContinueWith(doneA => {

                var taskSetB = new List<Task> {
                    Task.Run(() =>
                    {
                        var instance = (PatientPhoneNumbersMapping)mapInstances[4].Value;
                        instance.CreatePatientPhoneNumbersMapping();
                    }),
                    Task.Run(() =>
                    {
                        var instance = (InsuranceCompaniesMapping)mapInstances[5].Value;
                        instance.CreateInsuranceCompanyMapping();
                    }),
                    Task.Run(() =>
                    {
                        var instance = (InsurancePlansMapping)mapInstances[6].Value;
                        instance.CreateInsurancePlansMapping();
                    }),
                    Task.Run(() =>
                    {
                        var instance = (DMDataMapping)mapInstances[7].Value;
                        instance.CreateDMDataMapping();
                    }),
                    Task.Run(() =>
                    {
                        var instance = (TimeSlotsMapping)mapInstances[8].Value;
                        instance.CreateTimeSlotsMapping();
                    }),
                    Task.Run(() =>
                    {
                        var instance = new PumpSettingMapping();
                        instance.CreatePumpSettingMapping();
                    }),
                    Task.Run(() =>
                    {
                        var instance = new PumpTimeSlotsMapping();
                        instance.CreatePumpTimeSlotsMapping();
                    })
                };

                Task.WhenAll(taskSetB).ContinueWith(doneB => {
                    var taskSetC = new List<Task> {
                        Task.Run(() =>
                        {
                            var instance = (SubscriptionsMapping)mapInstances[10].Value;
                            instance.CreateSubscriptionMapping();
                        }),
                        Task.Run(() =>
                        {
                            var instance = new PumpProgramsMapping();
                            instance.CreatePumpProgramsMapping();
                        })
                    };

                    Task.WhenAll(taskSetC).ContinueWith(doneC => {
                        var taskSetD = new List<Task> {
                            Task.Run(() =>
                            {
                                var instance = new PumpsMapping();
                                instance.CreatePumpsMapping();
                            })
                        };

                        Task.WhenAll(taskSetD).ContinueWith(doneD => {
                            var taskSetE = new List<Task> {
                                Task.Run(() =>
                                {
                                    var instance = (DeviceMeterReadingHeaderMapping)mapInstances[9].Value;
                                    instance.CreateDeviceMeterReadingHeaderMapping();
                                })
                            };

                            Task.WhenAll(taskSetE).ContinueWith(doneE => {
                                var taskSetF = new List<Task> {
                                    Task.Run(() =>
                                    {
                                        var instance = (MeterReadingMapping)mapInstances[11].Value;
                                        instance.CreateDeviceMeterReadingMapping();
                                    })
                                };

                                Task.WhenAll(taskSetF).ContinueWith(doneF => {
                                    //UpdateContext();
                                    MappingsCompleted = true;
                                });
                            });
                        });
                    });
                });
            });
        }

        /// <summary>C:\Users\pjones\Source\Repos\FirebirdSqlMigration\FirebirdSqlMigration\Console.Dev\Program.cs
        /// Updates the database context with in-memory entities and saves the changes.
        /// </summary>
        public void UpdateContext()
        {
            for (int i = 0; i < mapInstances.Count; i++)
            {
                mapInstances[i].Value.AddToContext();
                mapInstances[i].Value.SaveChanges();
            }

            //using (var ctx = new NuMedicsGlobalEntities())
            //{
            //    Array.ForEach(ctx.Pumps.ToArray(), p =>
            //    {
            //        p.PumpPrograms = new List<PumpProgram>();

            //        var tupList = MemoryMappings.GetAllPumpPrograms().Where(w => w.Key == p.UserId).Select(s => s.Value).ToArray();
            //        Array.ForEach(tupList, l =>
            //        {
            //            Array.ForEach(l.ToArray(), g =>
            //            {
            //                var prog = new PumpProgram
            //                {
            //                    CreationDate = g.Item2.CreationDate,
            //                    NumOfSegments = g.Item2.NumOfSegments,
            //                    ProgramKey = g.Item2.ProgramKey,
            //                    ProgramName = g.Item2.ProgramName,
            //                    Source = g.Item2.Source,
            //                    Valid = g.Item2.Valid
            //                };

            //                p.PumpPrograms.Add(prog);
            //            });
            //        });
            //    });

            //    ctx.SaveChanges();
            //}

            //AddDmDataSet();

            //CommitExecution();
        }

        //private void AddDmDataSet()
        //{
        //    using (var ctx = new NuMedicsGlobalEntities())
        //    {
        //        Array.ForEach(MemoryDiabetesManagementData.DMDataCollection.ToArray(), d => {
        //            var pd = ctx.PatientDevices.Where(w => w.UserId == d.UserId).FirstOrDefault();

        //            if (pd != null)
        //            {
        //                d.PatientDevice = pd;
        //                ctx.DiabetesManagementDatas.Add(d);
        //            }
        //        });

        //        ctx.SaveChanges();
        //    }
        //}


        /// <summary>
        /// Commits the transaction.
        /// </summary>
        private void CommitExecution()
        {
            //throw new NotImplementedException();
            try
            {
                TransactionManager.ExecuteTransaction(); //TESTING ONLY
            }
            catch (Exception e)
            {
                throw;
            }
        }

    }
}
