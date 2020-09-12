using System;

namespace User
{
    public class UserModel
    {
        public event Action Buy;
        public event Action CreateNewGame;

        private readonly string _firstName;
        private readonly string _secondName;
        private readonly string _email;
        private readonly string _password;
        public string Id;
        public bool IsAuthorization;
        public bool InSession;
        public bool IsLeader;
        public string SessionId;
        public bool IsCameraPlays;
        public string Permission;

        public UserModel()
        {
            
        }

        public UserModel(string firstName,string secondName,string email,string password)
        {
            _firstName = firstName;
            _secondName = secondName;
            _email = email;
            _password = password;
        }

        

        public string GetFirstName()
        {
            return _firstName;
        }

        public string GetSecondName()
        {
            return _secondName;
        }

        public string GetEmail()
        {
            return _email;
        }

        public string GetPassword()
        {
            return _password;
        }

        public void OnCreateNewGame()
        {
            CreateNewGame?.Invoke();
        }

        public void OnBuy()
        {
            Buy?.Invoke();
        }
    }
}