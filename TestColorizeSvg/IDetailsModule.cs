namespace TestColorizeSvg
{
    public interface IDetailsModule
    {
        public Control GetControl();
        public bool Initialized { get; set; }
        public Task Initialize();
        public Task RefreshData();
    }
}
