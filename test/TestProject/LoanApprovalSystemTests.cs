namespace mutation_testing;

using NUnit.Framework;

public class LoanApprovalSystemTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ApproveLoan_ShouldReturnApprovedLowRate_WhenCriteriaForLowRateAreMet()
    {
        // Arrange
        var loanSystem = new LoanApprovalSystem();
        decimal income = 120000;       // High income threshold for low-rate approval
        int creditScore = 780;         // High credit score threshold for low-rate approval
        decimal loanAmount = 300000;   // Loan amount that meets the ratio criteria
        int loanDurationYears = 15;    // Loan duration within acceptable range

        // Act
        string result = loanSystem.ApproveLoan(income, creditScore, loanAmount, loanDurationYears);

        // Assert
        Assert.That(result, Is.EqualTo("Approved - Low Rate"), 
            "Loan approval did not return 'Approved - Low Rate' when criteria were met.");
    }
}
