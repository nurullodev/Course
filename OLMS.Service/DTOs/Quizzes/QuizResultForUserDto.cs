namespace OLMS.Service.DTOs.Quizzes;

public class QuizResultForUserDto
{
    public long Id { get; set; }
    public string Question { get; set; }
    public string VariantOne { get; set; }
    public string VariantTwo { get; set; }
    public string VariantThree { get; set; }
}