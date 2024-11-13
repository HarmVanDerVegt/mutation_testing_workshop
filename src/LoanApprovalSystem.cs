namespace mutation_testing;

public class LoanApprovalSystem
{
    public string ApproveLoan(decimal income, int creditScore, decimal loanAmount, int loanDurationYears)
    {
        if (income <= 0)
            throw new ArgumentOutOfRangeException("Income must be greater than 0.");
        if (creditScore < 300 || creditScore > 850)
            throw new ArgumentOutOfRangeException("Credit score must be between 300 and 850.");
        if (loanAmount <= 0)
            throw new ArgumentOutOfRangeException("Loan amount must be greater than 0.");
        if (loanDurationYears <= 0 || loanDurationYears > 30)
            throw new ArgumentOutOfRangeException("Loan duration must be between 1 and 30 years.");

        // Decision rules
        if (creditScore < 500 || income < 20000 || loanAmount > income * 5 || loanDurationYears > 20)
            return "Declined";

        if (creditScore >= 750 && income >= 100000 && loanAmount <= income * 3)
            return "Approved - Low Rate";

        return "Approved - Standard Rate";
    }
}
