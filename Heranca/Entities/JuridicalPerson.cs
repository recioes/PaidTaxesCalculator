using System;

namespace Heranca.Entities
{
    class JuridicalPerson : TaxPayer
    {
        public int NumberEmployees { get; set; }

        public JuridicalPerson(string nome, double rendaAnual, int numberEmployees)
            : base(nome, rendaAnual)
        {
            NumberEmployees = numberEmployees;
        }


        public override double GetTaxValue()
        {
            if (NumberEmployees <= 10)
            {
                return AnnualIncome * 0.16;
            }
            else
            {
                return AnnualIncome * 0.14;
            }

        }
    }
}