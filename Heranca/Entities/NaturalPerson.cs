using System;

namespace Heranca.Entities
{
    class NaturalPerson : TaxPayer
    {
        public double HealthExpenses { get; set; }

        public NaturalPerson(string nome, double rendaAnual, double healthExpenses) : base(nome, rendaAnual)
        {
            HealthExpenses = healthExpenses;
        }

        public override double GetTaxValue()
        {
            if (AnnualIncome < 2000)
            {
                return AnnualIncome * 0.15 - HealthExpenses * 0.5;
            }
            else
            {
                return AnnualIncome * 0.25 - HealthExpenses * 0.5;
            }
            

        }
    }
}
