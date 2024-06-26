using CodeBE_LEM.Controllers.JobController;
using CodeBE_LEM.Entities;
using System;
using System.Collections.Generic;

namespace CodeBE_LEM.Controllers.BoardController;

public class Board_JobDTO
{
    public long Id { get; set; }

    public long CardId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public int? Order { get; set; }

    public DateTime? StartAt { get; set; }

    public DateTime? EndAt { get; set; }

    public string? Color { get; set; }

    public int? NoTodoDone { get; set; }

    public long? CreatorId { get; set; }

    public DateTime? CreateAt { get; set; }

    public DateTime? UpdateAt { get; set; }

    public Board_AppUserDTO? Creator { get; set; }

    public List<Board_TodoDTO> Todos { get; set; } = new List<Board_TodoDTO>();

    public Board_JobDTO() { }

    public Board_JobDTO(Job Job)
    {
        Id = Job.Id;
        CardId = Job.CardId;
        Name = Job.Name;
        Order = Job.Order;
        Description = Job.Description;
        StartAt = Job.StartAt;
        EndAt = Job.EndAt;
        Color = Job.Color;
        NoTodoDone = Job.NoTodoDone;
        CreatorId = Job.CreatorId;
        CreateAt = Job.CreatedAt;
        UpdateAt = Job.UpdateAt;
        Creator = Job.Creator == null ? null : new Board_AppUserDTO(Job.Creator);
        Todos = Job.Todos?.Select(x => new Board_TodoDTO(x)).ToList();
    }
}
