public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PersonalNumber { get; set; }

    public bool IsPersonalNumberValid()
    {
        int sum = 0;
        bool doubleDigit = true;

        for (int i = 0; i < PersonalNumber.Length; i++)
        {
            int digit = int.Parse(PersonalNumber[i].ToString());
            digit *= doubleDigit ? 2 : 1;
            sum += digit > 9 ? digit - 9 : digit;
            doubleDigit = !doubleDigit;
        }

        return sum % 10 == 0;
    }

    public string GetGender()
    {
        int genderDigit = int.Parse(PersonalNumber[8].ToString());
        return genderDigit % 2 == 0 ? "Female" : "Male";
    }
}
