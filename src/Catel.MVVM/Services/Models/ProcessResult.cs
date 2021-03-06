﻿namespace Catel.Services
{
    public class ProcessResult
    {
        public ProcessResult(ProcessContext context)
        {
            Argument.IsNotNull(nameof(context), context);

            Context = context;
        }

        public ProcessContext Context { get; }

        public int ExitCode { get; set; }
    }
}
