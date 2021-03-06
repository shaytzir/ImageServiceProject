﻿using Infrastructure.Enums;
using Infrastructure.Modal;
using Infrastructure.Event;
using System;
using System.Collections.Generic;

namespace ImageService.Logging
{
    /// <summary>
    /// Inteface for the logging service - raises event and notifying subscribers
    /// </summary>
    public interface ILoggingService
    {
        /// <summary>
        /// an event saying a new message was recieved.
        /// </summary>
        event EventHandler<MessageRecievedEventArgs> MessageRecieved;
        List<MessageRecievedEventArgs> LogList
        {
            set;
            get;
        }

        /// <summary>
        /// Logging the Message. notifying all subscribers.
        /// </summary>
        /// <param name="message">message to log</param>
        /// <param name="type">message type - failure/info</param>
        void Log(string message, MessageTypeEnum type);
    }
}