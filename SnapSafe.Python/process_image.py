
import sys
from PIL import Image  # Install with `pip install pillow`

def process_image(image_path):
    try:
        img = Image.open(image_path)
        print(image_path)
        width, height = img.size
        return f"Image processed: {width}x{height} pixels"
    except Exception as e:
        return f"Error processing image: {str(e)}"

if __name__ == "__main__":
    if len(sys.argv) < 2:
        print("No image provided")
        sys.exit(1)

    image_file = sys.argv[1]
    result = process_image(image_file)
    print(result)