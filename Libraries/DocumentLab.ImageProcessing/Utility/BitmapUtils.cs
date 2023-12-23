namespace DocumentLab.ImageProcessor.Utility
{
  using ImageMagick;
  using System.Drawing;

  public static class BitmapUtils
  {
    public static Bitmap Resample(Bitmap image, int dpix, int dpiy)
    {
      MagickFactory factory = new MagickFactory();
      using (var resampled = new MagickImage(factory.Image.Create(image)))
      {
        resampled.Resample(dpix, dpiy);
        return resampled.ToBitmap();
      }
    }
  }
}
