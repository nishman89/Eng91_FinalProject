using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eng91FinalProjectAPI.Data
{
    public class Model
    {

        public class TraineeResponse : IResponse
        {
            public Response response { get; set; }
            public Trainee[] trainees { get; set; }
        }


        public class ErrorResponse : IResponse
        {
            public Response response { get; set; }
            public string[] errors { get; set; }
        }


        public class TokenResponse : IResponse
        {
            public Response response { get; set; }
            public bool success { get; set; }
            public string token { get; set; }
        }

        public class Response
        {
            public int statusCode { get; set; }
        }

        public class Trainee
        {
            public string title { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public Course course { get; set; }
            public Profile profile { get; set; }
        }

        public class Course
        {
            public string name { get; set; }
            public string location { get; set; }
            public Trainer trainer { get; set; }
            public Stream stream { get; set; }
        }

        public class Trainer
        {
            public string title { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string location { get; set; }
        }

        public class Stream
        {
            public string name { get; set; }
        }

        public class Profile
        {
            public object photoUrl { get; set; }
            public object gitHub { get; set; }
            public object linkedIn { get; set; }
            public string summary { get; set; }
            public string lifeStory { get; set; }
            public string workMotivation { get; set; }
            public string skills { get; set; }
            public string personalCharacteristics { get; set; }
            public string interests { get; set; }
            public string recentEmployment { get; set; }
            public string education { get; set; }
            public string certifications { get; set; }
            public string volunteering { get; set; }
            public string additionlAchievements { get; set; }
        }

    }
}
