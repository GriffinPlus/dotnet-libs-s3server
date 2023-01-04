///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// This file is part of the Griffin+ common library suite (https://github.com/griffinplus/dotnet-libs-s3server)
// The source code is licensed under the MIT license.
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace GriffinPlus.Lib.S3Server
{
	/// <summary>
	/// An ASP.NET Core controller providing an Amazon S3 compliant interface.
	/// </summary>
	[ApiController]
	// [Route("[controller]")]
	[Route("")]
	public class S3Controller : ControllerBase
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="S3Controller"/> class.
		/// </summary>
		public S3Controller()
		{

		}

		private static readonly string[] Summaries = new[]
		{
			"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
		};


		[HttpGet]
		public IEnumerable<string> Get()
		{
			return new[] { "A", "B", "C" };
		}

	}
}
