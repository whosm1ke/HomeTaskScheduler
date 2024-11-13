﻿namespace HomeTaskScheduler.Domain.Enums;

public enum SubmissionStatus
{
    Assigned,
    DoneInTime,
    DoneWithLate,
    Late,
    ReturnedWithoutMark,
    ReturnedWithMark,
}