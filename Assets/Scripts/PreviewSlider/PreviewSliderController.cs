
namespace PreviewSlider
{
    public class PreviewSliderController : IController
    {
        private readonly PreviewSliderContainer _container;

        public PreviewSliderController(PreviewSliderContainer container)
        {
            _container = container;
        }
        
        public void Deactivate()
        {
            _container.NextButton.onClick.RemoveListener(OnClickNext);
        }

        public void Activate()
        {
            _container.Next();
            _container.NextButton.onClick.AddListener(OnClickNext);
        }

        private void OnClickNext()
        {
            _container.IndexItem++;
            _container.Next();
            if (_container.IndexItem == _container.MaxCount)
            {
                _container.TextButton.text = "Start";
            }
        }
    }
}