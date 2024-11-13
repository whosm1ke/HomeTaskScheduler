﻿using HomeTaskScheduler.Application.DTO.Common;

namespace HomeTaskScheduler.Application.DTO.Users;

public class StudentDto : AbstractUserDto
{
    public ICollection<Guid> Tasks { get; set; }
    public ICollection<Guid> Submissions { get; set; }
    public ICollection<Guid> Courses { get; set; }
}