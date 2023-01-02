///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// This file is part of the Griffin+ common library suite (https://github.com/griffinplus/dotnet-libs-s3server)
// The source code is licensed under the MIT license.
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using Xunit;

namespace GriffinPlus.Lib.S3Server
{

	/// <summary>
	/// Unit tests targeting the <see cref="S3Controller"/> class.
	/// </summary>
	public class S3ControllerTests
	{
		/// <summary>
		/// Tests creating an instance of the <see cref="S3Controller"/> class using <see cref="S3Controller()"/>.
		/// </summary>
		[Fact]
		public void Create()
		{
			_ = new S3Controller();
		}
	}

}
