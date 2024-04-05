namespace Net.Leksi.Streams;

public interface IStreamFactory
{
    bool FileExists(Uri uri);
    Stream GetInputStream(Uri uri);
    Stream GetOutputStream(Uri uri, FileMode mode = FileMode.Create);
}
