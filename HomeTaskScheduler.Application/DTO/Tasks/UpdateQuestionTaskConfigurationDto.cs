﻿using HomeTaskScheduler.Domain.Enums;
using HomeTaskScheduler.Domain.ValueTypes;

namespace HomeTaskScheduler.Application.DTO.Tasks;

public class UpdateQuestionTaskConfigurationDto : UpdateTaskConfigurationDto
{
    public QuestionAnswer? QuestionAnswer { get; set; }
    public string? Question { get; set; }
    public AnswerUnit AnswerUnit { get; set; }
}