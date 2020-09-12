namespace User
{
    public class UserController : IController
    {
        private readonly GlobalContext _context;
        private readonly UserModel _model;

        public UserController(GlobalContext context, UserModel model)
        {
            _context = context;
            _model = model;
        }

        public void Deactivate()
        {
            _model.CreateNewGame -= OnCreateNewGame;
            _model.Buy -= OnBuy;
        }



        public void Activate()
        {
            _model.CreateNewGame += OnCreateNewGame;
            _model.Buy += OnBuy;
        }
        
        
        private void OnBuy()
        {
            throw new System.NotImplementedException();
        }
        
        
        private void OnCreateNewGame()
        {
            throw new System.NotImplementedException();
        }
    }
}