namespace Ass_1;
public class Member{
    public string FirstName{get;set;}
    public string LastName{get;set;}
    public string Gender{get;set;}
    public DateTime DateOfBirth{get;set;}
    public string PhoneNumber{get;set;}
    public string BirthPlace{get;set;}
    public int Age {
        get{
            return DateTime.Now.Year - DateOfBirth.Year;
        }
    }
    public bool IsGraduated{get;set;}

    public int TotalDays{
        get{
            return (int)(DateTime.Now - DateOfBirth).TotalDays;
        }
    }
    
}