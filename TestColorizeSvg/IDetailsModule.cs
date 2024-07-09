namespace TestColorizeSvg
{
    public interface IDetailsModule
    {
        public bool Initialized { get; set; }
        public Task RefreshData();
    }
}
