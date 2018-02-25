using AthenaHacks18.Models.Domain;
using AthenaHacks18.Models.Request;
using AthenaHacks18.Data;
using AthenaHacks18.Data.Providers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.ModelBinding;

namespace AthenaHacks18.Services
{
    public class WordsService : IWordsService
    {
        readonly IDataProvider dataProvider;

        public WordsService(IDataProvider dataProvider)
        {
            this.dataProvider = dataProvider;
        }

        public List<Word> GetAll()
        {
            List<Word> words = null;

            dataProvider.ExecuteCmd(
                "words_getall",
                null,
                delegate (IDataReader reader, short resultSetIndex)
                {
                    // this is called ONCE PER ROW that comes out of the database
                    int i = 0;

                    Word word = new Word();
                    word.WordName = reader.GetString(i++);
                    word.GradeLevel = reader.GetInt32(i++);
                    word.PartsOfSpeech = reader.GetString(i++);
                    word.DateCreated = reader.GetDateTime(i++);
                    word.DateModified = reader.GetDateTime(i++);
                    word.Definition = reader.GetSafeString(i++);
                    word.Example = reader.GetSafeString(i++);

                    if(words == null)
                    {
                        words = new List<Word>();
                    }

                    words.Add(word);
                });

            return words;
        }

        public Word GetByWord(string wordStr)
        {
            Word word = null;

            dataProvider.ExecuteCmd(
                "words_getbyword",
                delegate (SqlParameterCollection parameter)
                {
                    parameter.AddWithValue("@word", wordStr);
                },
                delegate (IDataReader reader, short resultSetIndex)
                {
                    // this is called ONCE PER ROW that comes out of the database

                    int i = 0;
                    word = new Word();
                    word.WordName = reader.GetString(i++);
                    word.GradeLevel = reader.GetInt32(i++);
                    word.PartsOfSpeech = reader.GetString(i++);
                    word.DateCreated = reader.GetDateTime(i++);
                    word.DateModified = reader.GetDateTime(i++);
                    word.Definition = reader.GetSafeString(i++);
                    word.Example = reader.GetSafeString(i++);
                });

            return word;
        }

        public List<Word> GetByGrade(int grade)
        {
            List<Word> words = null;

            dataProvider.ExecuteCmd(
                "words_getbygrade",
                delegate(SqlParameterCollection parameter)
                {
                    parameter.AddWithValue("@grade", grade);
                },
                delegate(IDataReader reader, short resultSetIndex)
                {
                    int i = 0;
                    Word word = new Word();
                    word.WordName = reader.GetString(i++);
                    word.GradeLevel = reader.GetInt32(i++);
                    word.PartsOfSpeech = reader.GetString(i++);
                    word.DateCreated = reader.GetDateTime(i++);
                    word.DateModified = reader.GetDateTime(i++);
                    word.Definition = reader.GetSafeString(i++);
                    word.Example = reader.GetSafeString(i++);

                    if(words == null)
                    {
                        words = new List<Word>();
                    }

                    words.Add(word);
                });

            return words;
        }


        public void Create(WordCreateUpdateRequest req)
        {
            dataProvider.ExecuteNonQuery(
                "words_insert",
                delegate(SqlParameterCollection parameter)
                {
                    parameter.AddWithValue("@word", req.WordName);
                    parameter.AddWithValue("@grade_level", req.GradeLevel);
                    parameter.AddWithValue("@parts_of_speech", req.PartsOfSpeech);
                    parameter.AddWithValue("@definition", req.Definition);
                    parameter.AddWithValue("@examples", req.Example);
                });
        }

        public void Update(WordCreateUpdateRequest req)
        {
            dataProvider.ExecuteNonQuery(
                "words_update",
                delegate (SqlParameterCollection parameter)
                {
                    parameter.AddWithValue("@word", req.WordName);
                    parameter.AddWithValue("@grade_level", req.GradeLevel);
                    parameter.AddWithValue("@parts_of_speech", req.PartsOfSpeech);
                    parameter.AddWithValue("@definition", req.Definition);
                    parameter.AddWithValue("@examples", req.Example);
                });
        }
        
    }
}
