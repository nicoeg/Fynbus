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

        public List<string> GetAllCompanyNames()
        {
            List<string> tempStringList = new List<string>();

            foreach (Company company in CompanyDatabaseFacade.GetAllCompanyNames())
            {
                tempStringList.Add(company.Name);
            }

            return tempStringList;
        }

        public List<Firm> GetFirmsFromCompany(int Company) {
            return FirmDatabaseFacade.GetFirmsFromCompany(Company);
        }
    }
}
