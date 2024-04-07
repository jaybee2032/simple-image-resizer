
namespace Simple_Image_Resizer
{
	public class ImageResizerController
	{
        public async Task ResizeImageAsync(string inputImagePath, string outputImagePath, int newWidth, int newHeight)
		{
			await ImageResizerService.ResizeImageAsync(inputImagePath, outputImagePath, newWidth, newHeight);
		}
    }
}