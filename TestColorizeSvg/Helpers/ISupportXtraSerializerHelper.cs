using DevExpress.Utils.Serializing;
using System.IO;

namespace TestColorizeSvg
{
    public static class ISupportXtraSerializerHelper
    {
        public static MemoryStream GetCurrentLayoutStream(this ISupportXtraSerializer control)
        {
            var stream = new MemoryStream();
            control?.SaveLayoutToStream(stream);
            stream.Seek(0, SeekOrigin.Begin);
            return stream;
        }

        public static void SetControlBytesLayout(this ISupportXtraSerializer control, byte[]? bytes)
        {
            try
            {
                if (bytes is null || bytes.Length == 0) return;
                var stream = new MemoryStream(bytes);
                control?.RestoreLayoutFromStream(stream);
                stream.Seek(0, SeekOrigin.Begin);
            }
            catch
            {

            }
        }
    }
}
