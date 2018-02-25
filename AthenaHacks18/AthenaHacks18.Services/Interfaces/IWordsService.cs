using System.Collections.Generic;
using AthenaHacks18.Models.Domain;
using AthenaHacks18.Models.Request;

namespace AthenaHacks18.Services
{
    public interface IWordsService
    {
        void Create(WordCreateUpdateRequest req);
        List<Word> GetAll();
        Word GetByGrade(int grade);
        Word GetByWord(string wordStr);
        void Update(WordCreateUpdateRequest req);
    }
}