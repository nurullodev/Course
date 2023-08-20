using OLMS.Service.DTOs.Quizzes;

namespace OLMS.Service.Interfaces;

public interface IQuizService
{
    ValueTask<QuizResultDto> AddAsync(QuizCreationDto dto);
    ValueTask<QuizResultDto> ModifyAsync(QuizCreationDto dto);
    ValueTask<bool> DeleteAsync(long id);
    ValueTask<QuizResultDto> RetrieveByIdAsync(long id);
    ValueTask<IEnumerable<QuizResultDto>> RetrieveAllAsync();
    ValueTask<IEnumerable<QuizResultDto>> GetByLessonIdAsync(long lessonId);
    ValueTask<IEnumerable<QuizResultForUserDto>> SearchByLessonIdAsync(long lessonId, long userId);
}