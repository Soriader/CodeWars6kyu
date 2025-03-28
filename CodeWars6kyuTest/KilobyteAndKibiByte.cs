namespace CodeWars6kyuTest;

using CodeWars6kyu;

public class KilobyteAndKibiByte
{
    [Test]
    public void KilobyteAndKibiByteTest()
    {
        Assert.That(KilobyteAndKibiByteTask.MemorySizeConversion("1 KiB"), Is.EqualTo("1.024 kB"));
        Assert.That(KilobyteAndKibiByteTask.MemorySizeConversion("1 kB"), Is.EqualTo("0.977 KiB"));
        Assert.That(KilobyteAndKibiByteTask.MemorySizeConversion("1 MiB"), Is.EqualTo("1.049 MB"));
        Assert.That(KilobyteAndKibiByteTask.MemorySizeConversion("1 MB"), Is.EqualTo("0.954 MiB"));
        Assert.That(KilobyteAndKibiByteTask.MemorySizeConversion("1 GB"), Is.EqualTo("0.931 GiB"));
        Assert.That(KilobyteAndKibiByteTask.MemorySizeConversion("1 GiB"), Is.EqualTo("1.074 GB"));
        Assert.That(KilobyteAndKibiByteTask.MemorySizeConversion("1 TB"), Is.EqualTo("0.909 TiB"));
        Assert.That(KilobyteAndKibiByteTask.MemorySizeConversion("1 TiB"), Is.EqualTo("1.1 TB"));
    }
}
