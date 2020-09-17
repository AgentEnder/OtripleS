﻿// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE AS LONG AS SOFTWARE FUNDS ARE DONATED TO THE POOR
// ---------------------------------------------------------------

using System.Linq;
using System.Threading.Tasks;
using OtripleS.Web.Api.Models.StudentGuardians;

namespace OtripleS.Web.Api.Services.StudentGuardians
{
	public interface IStudentGuardianService
	{
		IQueryable<StudentGuardian> RetrieveAllStudentGuardians();
		ValueTask<StudentGuardian> ModifyStudentGuardianAsync(StudentGuardian studentGuardian);
	}
}
