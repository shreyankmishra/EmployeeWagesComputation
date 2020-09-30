using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWage
{
    class CompanyEmpWage
    {
        public string company;
        public int empRatePerHour, numOfWorkingDays, maxHoursPerMonth, totalEmpWage;
        public CompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHrsPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHrsPerMonth;
        }
        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }
        public string toString()
        {
            return "Total Emp Wage for Company " + this.company + " is " + this.totalEmpWage; ;
        }
    }
}