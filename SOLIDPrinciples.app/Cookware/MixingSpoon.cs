namespace SOLIDPrinciples.app.Cookware
{
    public class MixingSpoon : IWashable
    {
        private bool _isDirty;

        public bool IsDirty()
        {
            return _isDirty;
        }

        public void Wash()
        {
            _isDirty = false;
        }

        public void Use()
        {
            _isDirty = true;
        }
    }
}