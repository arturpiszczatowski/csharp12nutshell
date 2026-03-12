using ABriefHistory;
using ABriefHistory.CSharp10;
using ABriefHistory.CSharp11;
using ABriefHistory.CSharp12;
using ABriefHistory.CSharp6;
using ABriefHistory.CSharp7;
using ABriefHistory.CSharp8;
using ABriefHistory.CSharp9;

// Used when you target .NET 8
#region C#12
//CollectionExpressions.Run();
//PrimaryConstructors.Run();
//DefaultLambdaParameters.Run();
//AliasAnyType.Run();
//InlineArrays.Run();
#endregion

// Used when you target .NET 7
#region C#11
//RawStringLiterals.Run();
//UTF8Strings.Run();
//ListPatterns.Run();
//RequiredMembers.Run();
//GenericMath.Run();
#endregion

// Used when you target .NET 6
#region C#10
//FileScopedNamespaces.Run();
//GlobalUsingDirective.Run();
//NondestructiveMutationForAnonymousTypes.Run();
//NewDeconstructionSyntax.Run();
//RecordStructs.Run();
//LambdaExpressionEnhancments.Run();
//NestedPropertyPatterns.Run();
//CallerArgumentExpression.Run();
#endregion

// Used when you target .NET 5
#region C#9
//InitOnlySetters.Run();
//Records.Run();
//PatternMatchingImprovements.Run();
//TargetTypedNewExpression.Run();
#endregion

// Usen when you target .Net Core 3 and .Net Standard 2.1
#region C#8
//IndicesAndRanges.Run();
//NullCoalescingAssignment.Run();
//UsingDeclarations.Run();
//ReadOnlyMembers.Run();
//StaticLocalMethods.Run();
//DefaultInterfaceMembers.Run();
//SwitchExpressions.Run();
//TuplePositionalPropertyPatterns.Run();
//await AsynchronousStreams.Run();
#endregion

// Used when you target .Net Core 2, .Net Framework 4.6 to 4.8, or .Net Standard 2.0
#region C#7.x
//NumericLiteralImprovements.Run();
//OutVariablesAndDiscards.Run();
//TypePattersAndPatternVariables.Run();
//LocalMethods.Run();
//MoreExpressionBodiedMembers.Run();
//Deconstructors.Run();
//Tuples.Run();
//ThrowExpressions.Run();
#endregion

// Features a new-generation compiler, completely written in C# - Known as project "Roslyn"
// Exposes the entire compilation pipeline via libraries, allowing you to perform code analysis on arbitrary source code
// The compile is open source available @ https://github.com/dotnet/roslyn
#region C#6
//NullConditional.Run();
//ExpressionBodiedFunctions.Run();
//PropertyInitializers.Run();
//IndexInitializers.Run();
//await ExceptionFilters.Run();
//UsingStaticImport.Run();
//NameOf.Run();
#endregion