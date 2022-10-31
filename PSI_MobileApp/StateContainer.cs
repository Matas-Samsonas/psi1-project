using ProfileClasses;

namespace PSI_MobileApp
{
    public class StateContainer
    {
        private Profile supplier;

        public Profile Supplier
        {
            get => supplier;
            set
            {
                supplier = value;
                NotifyStateChanged();
            }
        }
#nullable enable
        public event Action? OnChange;

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
