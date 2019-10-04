using System;
using System.IO;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace WK.Apps.Sharp64.Helpers
{
    public static class EncoderDecoder
    {
        #region Synchronous

        /// <summary>
        /// Encodes a string into Base64 format.
        /// </summary>
        /// <param name="content">The string to encode.</param>
        public static string Base64Encode(string content)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(content);
            return Convert.ToBase64String(plainTextBytes);
        }

        /// <summary>
        /// Decodes a formatted Base64 string into plain text.
        /// </summary>
        /// <param name="plainText">The Base64 string to decode.</param>
        public static string Base64Decode(string base64EncodedData)
        {
            if (IsBase64Formatted(base64EncodedData))
            {
                var base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
                return Encoding.UTF8.GetString(base64EncodedBytes);
            }
            else
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// Determines whether a particular string is in Base64 format.
        /// </summary>
        /// <param name="content">The string to determine.</param>
        public static bool IsBase64Formatted(string content)
        {
            content = content.Trim();

            return (content.Length % 4 == 0) &&
                   Regex.IsMatch(content, @"^[a-zA-Z0-9\+/]*={0,3}$", RegexOptions.None);

        }

        /// <summary>
        /// Determines if a file is of a supported image-type.
        /// </summary>
        /// <param name="fileName">
        /// The filename, including its extension.
        /// </param>
        public static bool IsSupportedImage(string fileName)
        {
            string extension = Path.GetExtension(fileName).Replace(".", "").ToLower();

            if (!string.IsNullOrWhiteSpace(extension))
            {
                if (extension == "jpg" || extension == "jpeg" || 
                    extension == "png" || extension == "gif" || 
                    extension == "ico" || extension == "tif" ||
                    extension == "tiff" || extension == "enci")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Determines if a file contains 
        /// supported text formatting.
        /// </summary>
        /// <param name="fileName">
        /// The filename, including its extension.
        /// </param>
        public static bool IsSupportedFile(string fileName)
        {
            string extension = Path.GetExtension(fileName).Replace(".", "").ToLower();

            // Currently, due to the huge number of 
            // file extensions, this may not be the best  
            // possible way to filter out text-based formats. 
            // However a considerable no. of file formats have  
            // been filtered by default. You can add extensions 
            // or even use a better alternative to this.
            if (!string.IsNullOrWhiteSpace(extension))
            {
                if (extension == "txt" || extension == "html" ||
                    extension == "css" || extension == "js" ||
                    extension == "php" || extension == "cs" ||
                    extension == "java" || extension == "py" ||
                    extension == "rb" || extension == "ps" ||
                    extension == "ps1" || extension == "vb" ||
                    extension == "enc") // Please preserve "enc" format.)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Encodes an image into Base64 format.
        /// </summary>
        /// <param name="imagePath">The path to the image.</param>
        public static string Base64EncodeImage(string imagePath)
        {
            try
            {
                using (Image image = Image.FromFile(imagePath))
                {
                    using (MemoryStream m = new MemoryStream())
                    {
                        image.Save(m, image.RawFormat);
                        byte[] imageBytes = m.ToArray();

                        return Convert.ToBase64String(imageBytes);
                    }
                }
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// Decodes a formatted Base64 image's data back to its original format.
        /// </summary>
        /// <param name="base64EncodedData">The Base64 image data to decode.</param>
        public static Image Base64DecodeImage(string base64EncodedData)
        {
            try
            {
                byte[] imageBytes = Convert.FromBase64String(base64EncodedData);
                MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);

                ms.Write(imageBytes, 0, imageBytes.Length);
                Image image = Image.FromStream(ms, true);

                return image;
            }
            catch (Exception)
            {
                return null;
            }
        }

        #endregion

        #region Asynchronous

        /// <summary>
        /// Encodes a string into Base64 format.
        /// </summary>
        /// <param name="content">The string to encode.</param>
        public static async Task<string> Base64EncodeAsync(string content)
        {
            return await Task.Run(() =>
            {
                return Base64Encode(content);
            });
        }

        /// <summary>
        /// Decodes a formatted Base64 string into plain text.
        /// </summary>
        /// <param name="base64EncodedData">The Base64 string to decode.</param>
        public static async Task<string> Base64DecodeAsync(string base64EncodedData)
        {
            return await Task.Run(() =>
            {
                return Base64Decode(base64EncodedData);
            });
        }

        /// <summary>
        /// Encodes an image into Base64 format.
        /// </summary>
        /// <param name="imagePath">The path to the image.</param>
        public static async Task<string> Base64EncodeImageAsync(string imagePath)
        {
            return await Task.Run(() =>
            {
                return Base64EncodeImage(imagePath);
            });
        }

        /// <summary>
        /// Decodes a formatted Base64 image's data into plain text.
        /// </summary>
        /// <param name="base64EncodedData">The Base64 image data to decode.</param>
        public static async Task<Image> Base64DecodeImageAsync(string base64EncodedData)
        {
            return await Task.Run(() =>
            {
                return Base64DecodeImage(base64EncodedData);
            });
        }

        #endregion
    }
}