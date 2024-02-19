﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VivaLifeHospital.Application.Features.Mediator.Commands.CommentCommands
{
    public class RemoveCommentCommand:IRequest
    {
        public int Id { get; set; }

        public RemoveCommentCommand(int id)
        {
            Id = id;
        }
    }
}
