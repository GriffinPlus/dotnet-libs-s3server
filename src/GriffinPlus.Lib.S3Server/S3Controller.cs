///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// This file is part of the Griffin+ common library suite (https://github.com/griffinplus/dotnet-libs-s3server)
// The source code is licensed under the MIT license.
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using Microsoft.AspNetCore.Mvc;

namespace GriffinPlus.Lib.S3Server
{
	/// <summary>
	/// An ASP.NET Core controller providing an Amazon S3 compliant interface.
	/// </summary>
	[ApiController]
	public class S3Controller : ControllerBase
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="S3Controller"/> class.
		/// </summary>
		public S3Controller()
		{

		}
	}
}
