﻿using MediatR;
using System.Text.Json.Serialization;

namespace CleanArchitecture.Application.Features.Streamers.Commands.UpdateStreamer
{
    public  class UpdateStreamerCommandRequest : IRequest 
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string Url { get; set; } = string.Empty;
    }
}
