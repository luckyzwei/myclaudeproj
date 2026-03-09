using System;
using System.IO;
using System.Text;
using UnityEngine;

namespace Crosstales.Common.Util
{
	public static class FileHelper
	{
		private static string _applicationDataPath;

		private static string _applicationTempPath;

		private static string _applicationPersistentPath;

		private static char[] _invalidFilenameChars;

		private static char[] _invalidPathChars;

		public static string StreamingAssetsPath => null;

		public static string ApplicationDataPath => null;

		public static string ApplicationTempPath => null;

		public static string ApplicationPersistentPath => null;

		public static string TempFile => null;

		public static string TempPath => null;

		[RuntimeInitializeOnLoadMethod]
		private static void initialize()
		{
		}

		public static bool isUnixPath(string path)
		{
			return false;
		}

		public static bool isWindowsPath(string path)
		{
			return false;
		}

		public static bool isUNCPath(string path)
		{
			return false;
		}

		public static bool isURL(string path)
		{
			return false;
		}

		public static string ValidatePath(string path, bool addEndDelimiter = true, bool preserveFile = true, bool removeInvalidChars = true)
		{
			return null;
		}

		public static string ValidateFile(string path, bool removeInvalidChars = true)
		{
			return null;
		}

		public static bool HasPathInvalidChars(string path, bool ignoreNullOrEmpty = true)
		{
			return false;
		}

		public static bool HasFileInvalidChars(string file, bool ignoreNullOrEmpty = true)
		{
			return false;
		}

		public static string[] GetFilesForName(string path, bool isRecursive = false, params string[] filenames)
		{
			return null;
		}

		public static string[] GetFiles(string path, bool isRecursive = false, params string[] extensions)
		{
			return null;
		}

		public static string[] GetDirectories(string path, bool isRecursive = false)
		{
			return null;
		}

		public static string[] GetDrives()
		{
			return null;
		}

		public static bool CopyDirectory(string sourceDir, string destDir, bool move = false, bool moveSafe = true)
		{
			return false;
		}

		public static bool CopyFile(string sourceFile, string destFile, bool move = false, bool moveSafe = true)
		{
			return false;
		}

		public static bool MoveDirectory(string sourceDir, string destDir)
		{
			return false;
		}

		public static bool MoveFile(string sourceFile, string destFile)
		{
			return false;
		}

		public static string RenameDirectory(string path, string newName)
		{
			return null;
		}

		public static string RenameFile(string path, string newName)
		{
			return null;
		}

		public static bool DeleteFile(string file)
		{
			return false;
		}

		public static bool DeleteDirectory(string dir)
		{
			return false;
		}

		public static bool ExistsFile(string file)
		{
			return false;
		}

		public static bool ExistsDirectory(string path)
		{
			return false;
		}

		public static string CreateDirectory(string path, string folderName)
		{
			return null;
		}

		public static bool CreateDirectory(string path)
		{
			return false;
		}

		public static string CreateFile(string path, string fileName)
		{
			return null;
		}

		public static bool CreateFile(string path)
		{
			return false;
		}

		public static bool isDirectory(string path, bool checkForExtensions = true)
		{
			return false;
		}

		public static bool isFile(string path, bool checkForExtensions = true)
		{
			return false;
		}

		public static bool isRoot(string path)
		{
			return false;
		}

		public static string GetFileName(string path, bool removeInvalidChars = true)
		{
			return null;
		}

		public static string GetCurrentDirectoryName(string path)
		{
			return null;
		}

		public static string GetDirectoryName(string path)
		{
			return null;
		}

		public static long GetFilesize(string path)
		{
			return 0L;
		}

		public static string GetExtension(string path)
		{
			return null;
		}

		public static DateTime GetLastModifiedDate(string path)
		{
			return default(DateTime);
		}

		public static string ReadAllText(string sourceFile, Encoding encoding = null)
		{
			return null;
		}

		public static string[] ReadAllLines(string sourceFile, Encoding encoding = null)
		{
			return null;
		}

		public static byte[] ReadAllBytes(string sourceFile)
		{
			return null;
		}

		public static bool WriteAllText(string destFile, string text, Encoding encoding = null)
		{
			return false;
		}

		public static bool WriteAllLines(string destFile, string[] lines, Encoding encoding = null)
		{
			return false;
		}

		public static bool WriteAllBytes(string destFile, byte[] data)
		{
			return false;
		}

		public static bool ShowPath(string path)
		{
			return false;
		}

		public static bool ShowFile(string file)
		{
			return false;
		}

		public static bool OpenFile(string file)
		{
			return false;
		}

		[Obsolete("Please use 'HasPathInvalidChars' instead.")]
		public static bool PathHasInvalidChars(string path)
		{
			return false;
		}

		[Obsolete("Please use 'HasFileInvalidChars' instead.")]
		public static bool FileHasInvalidChars(string file)
		{
			return false;
		}

		[Obsolete("Please use 'CopyDirectory' instead.")]
		public static bool CopyPath(string sourceDir, string destDir, bool move = false)
		{
			return false;
		}

		[Obsolete("Please use 'MoveDirectory' instead.")]
		public static bool MovePath(string sourceDir, string destDir)
		{
			return false;
		}

		private static void copyAll(DirectoryInfo source, DirectoryInfo target)
		{
		}
	}
}
