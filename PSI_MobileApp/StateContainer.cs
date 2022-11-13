using ProfileClasses;

namespace PSI_MobileApp
{
    public class StateContainer
    {
        private Guid id;

        public Guid Id
        {
            get => id;
            set
            {
                id = value;
                NotifyStateChanged();
            }
        }
#nullable enable
        public event Action? OnChange;

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
