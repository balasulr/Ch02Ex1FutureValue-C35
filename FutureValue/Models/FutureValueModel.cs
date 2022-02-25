namespace FutureValue.Models {

    public class FutureValueModel {

        public decimal MonthlyInvestment { get; set; }
        public decimal YearlyInterestRate { get; set; }
        public int Years { get; set; }

        public decimal CalculateFutureValue() {
            var months = Years * 12; // Could do int months here but decides to use var
            var monthlyInterestRate = YearlyInterestRate / 12 / 100;
            var futureValue = 0m; // The m forces it to be a decimal since without the m, var will default to an integer
            for(var i = 0; i < months; i++) {
                futureValue = (futureValue + MonthlyInvestment) * (1 + monthlyInterestRate);
            }
            return futureValue;
        }
    }
}
