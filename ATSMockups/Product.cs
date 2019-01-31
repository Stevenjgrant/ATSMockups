using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATSMockups
{
    public class Product
    {
        public string Code { get; }
        public string Name { get; }
        public decimal CaseCount { get; }
        public decimal VarRebate1 { get; set; }
        public decimal VarRebate2 { get; set; }
        public decimal VarRebate3 { get; set; }
        public decimal VarRebate4 { get; set; }
        public decimal VarRebate5 { get; set; }
        public decimal BaseCasePrice { get; set; }
        public decimal PromoCasePrice { get; set; }
        public bool Included { get; set; }

        public Product(string Code, string Name, int CaseCount, decimal BaseCasePrice)
        {
            this.Code = Code;
            this.Name = Name;
            this.CaseCount = CaseCount;
            this.BaseCasePrice = BaseCasePrice;
            PromoCasePrice = BaseCasePrice;
            Included = true;
        }

        public void CalculatePromoPrice()
        {
            PromoCasePrice = BaseCasePrice - (VarRebate1 + VarRebate2 + VarRebate3 + VarRebate4 + VarRebate5);
        }
    }
}
