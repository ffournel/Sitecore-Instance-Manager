﻿namespace SIM.Client.Commands
{
  using CommandLine;
  using JetBrains.Annotations;
  using SIM.Core.Commands;

  public class InstallCommandFacade : InstallCommand
  {
    [UsedImplicitly]
    public InstallCommandFacade()
    {
    }

    [Option('n', "name", Required = true)]
    public override string Name { get; set; }

    [Option('s', "sqlPrefix", HelpText = "Logical names prefix of SQL databases, by default equals to instance name")]
    public override string SqlPrefix { get; set; }

    [Option('p', "product")]
    public override string Product { get; set; }

    [Option('v', "version")]
    public override string Version { get; set; }

    [Option('r', "revision")]
    public override string Revision { get; set; }

    [Option('a', "attach", HelpText = "Attach SQL databases, or just update ConnectionStrings.config", DefaultValue = AttachDatabasesDefault)]
    public override bool? AttachDatabases { get; set; }
  }
}