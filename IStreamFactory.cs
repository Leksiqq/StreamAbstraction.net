namespace Net.Leksi.Streams;

public interface IStreamFactory
{
    Stream GetInputStream(Uri uri);
    Stream GetOutputStream(Uri uri, FileMode mode = FileMode.Create);
}
