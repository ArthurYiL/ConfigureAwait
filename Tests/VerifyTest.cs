﻿#if NET46
using System.Runtime.CompilerServices;
using ApprovalTests;
using Fody;
using Xunit;

public partial class ModuleWeaverTests
{
    [Fact]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DecompileExample()
    {
        Approvals.Verify(Ildasm.Decompile(testResult.AssemblyPath, "AssemblyToProcess.Example").Replace("\r\n", "\n").Replace("\n", "\r"));
    }

    [Fact]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DecompileIssue1()
    {
        Approvals.Verify(Ildasm.Decompile(testResult.AssemblyPath, "AssemblyToProcess.Issue1").Replace("\r\n","\n").Replace("\n","\r"));
    }

    [Fact]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DecompileGenericClass()
    {
        Approvals.Verify(Ildasm.Decompile(testResult.AssemblyPath, "AssemblyToProcess.GenericClass`1"));
    }

    [Fact]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DecompileGenericMethod()
    {
        Approvals.Verify(Ildasm.Decompile(testResult.AssemblyPath, "AssemblyToProcess.GenericMethod"));
    }

    [Fact]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DecompileCatchAndFinally()
    {
        Approvals.Verify(Ildasm.Decompile(testResult.AssemblyPath, "AssemblyToProcess.CatchAndFinally"));
    }
}

#endif