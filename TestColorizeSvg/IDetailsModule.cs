namespace TestColorizeSvg
{
    public interface IDetailsModule
    {
        public bool Initialized { get; set; }
        public Task Initialize();
        public Task RefreshData();
    }
}
