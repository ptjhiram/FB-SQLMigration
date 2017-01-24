﻿using NuLibrary.Migration.SQLDatabase.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuLibrary.Migration.Mappings.InMemoryMappings
{
    public static class MemoryMappings
    {
        private static ICollection<DiabetesManagementData> DMDataCollection = new List<DiabetesManagementData>();

        private static ICollection<Institution> InstitutionCollection = new List<Institution>();

        // key = firebird keyid for company
        // value = company name
        private static Dictionary<string, string> Companies = new Dictionary<string, string>();

        // Item1 = site id
        // Item2 = number of licenses
        // Item3 = Expiration date
        private static List<Tuple<int, int, DateTime>> NuLicenses = new List<Tuple<int, int, DateTime>>();

        // item1 = site id
        // item2 = patient id
        // item3 = user id
        private static List<Tuple<int, string, Guid>> patientInfo = new List<Tuple<int, string, Guid>>();

        public static void AddDiabetesManagementData(DiabetesManagementData dmData)
        {
            if (!DMDataCollection.Contains(dmData))
            {
                DMDataCollection.Add(dmData);
            }
        }

        public static ICollection<DiabetesManagementData> GetAllDiabetesManagementData()
        {
            return DMDataCollection;
        }

        public static void AddInstitution(Institution institution)
        {
            if (!InstitutionCollection.Contains(institution))
            {
                InstitutionCollection.Add(institution);
            }
        }

        public static ICollection<Institution> GetAllInstitutions()
        {
            return InstitutionCollection;
        }

        public static void AddCompnay(string companyKeyId, string compnayName)
        {
            if (!String.IsNullOrEmpty(compnayName))
            {
                if (!Companies.ContainsKey(companyKeyId))
                {
                    Companies.Add(companyKeyId, compnayName);
                }
            }
        }

        public static Dictionary<string, string> GetAllCompanies()
        {
            return Companies;
        }

        public static void AddNuLicense(int siteId, int numberLicenses, DateTime expirationDate)
        {
            if (siteId != 0)
            {
                var tup = new Tuple<int, int, DateTime>(siteId, numberLicenses, expirationDate);
                if (!NuLicenses.Contains(tup))
                {
                    NuLicenses.Add(tup);
                }
            }
        }

        public static List<Tuple<int, int, DateTime>> GetAllNuLicenses()
        {
            return NuLicenses;
        }

        public static Guid GetUserIdFromPatientInfo(int siteId, string patientId)
        {
            return patientInfo.Where(w => w.Item1 == siteId && w.Item2 == patientId).Select(s => s.Item3).FirstOrDefault();
        }

        public static void AddPatientInfo(int siteId, string patientId, Guid userId)
        {
            if (siteId != 0 && !String.IsNullOrEmpty(patientId) && userId != Guid.Empty)
            {
                var tup = new Tuple<int, string, Guid>(siteId, patientId, userId);
                if (!patientInfo.Contains(tup))
                {
                    patientInfo.Add(tup);
                }
            }
        }

        public static ICollection<Guid> GetAllUserIdsFromPatientInfo()
        {
            return patientInfo.Select(s => s.Item3).ToList();
        }

        public static int PatientCount()
        {
            return patientInfo.Count;
        }

        public static int NuLicenseCount()
        {
            return NuLicenses.Count;
        }

        public static int CompaniesCount()
        {
            return Companies.Count;
        }

        public static int InstitutionsCount()
        {
            return InstitutionCollection.Count;
        }

        public static int DMDataCount()
        {
            return DMDataCollection.Count;
        }
    }
}
