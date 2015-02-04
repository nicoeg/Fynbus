using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.DatabaseFacades;
using ModelLayer.Models;

namespace ControllerLayer
{
    public class Controller 
    {

        public Controller()
        {

        }

        public Dictionary<int, string> GetAllCompanies()
        {
            Dictionary<int, string> tempCompanyDictionary = new Dictionary<int, string>();

            foreach (Company company in CompanyDatabaseFacade.GetAllCompanies())
            {
                tempCompanyDictionary.Add(company.id, company.Name);
            }

            return tempCompanyDictionary;
        }



        public List<Firm> GetFirmsFromCompany(int Company) {
            return FirmDatabaseFacade.GetFirmsFromCompany(Company);
        }
    }
}
