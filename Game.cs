using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using Core.Abstractions;
using Core.Gamble;
using Core.Game;
using Core.Spins;

namespace JobsTestProjectLatest_2;

//Game Modes will be associated with runners in the following way:
public class GameModeRunners
{
    public static Dictionary<GameMode, IGameModeRunner> Runners =
        new()
        {
            {
    GameModeExtension.BaseSpin,
    new SpinGameModeRunner(new SpinMode
                       {
                           Evaluator = new SpinModeBaseSpin(GameModeExtension.BaseSpin),
                           AllowedSymbols =
                           [
                               SymbolExtensions.Hi1,
SymbolExtensions.Hi2,
SymbolExtensions.Hi3,
SymbolExtensions.Hi4,
SymbolExtensions.Low1,
SymbolExtensions.Low2,
SymbolExtensions.Low3,
SymbolExtensions.Low4,
SymbolExtensions.Scatter,

                           ],
                           AllowedTransitions = 
                           [
                               GameMode.None,
GameModeExtension.FreeSpins7,
GameModeExtension.FreeSpins9,
GameModeExtension.FreeSpins11,

                           ],
                           Paytable =
                               new()
                               {
                                   { SymbolExtensions.Wild, [0.5f,1f,2.5f,] },
{ SymbolExtensions.Hi1, [0.5f,1f,2.5f,] },
{ SymbolExtensions.Hi2, [0.3f,0.6f,1.5f,] },
{ SymbolExtensions.Hi3, [0.2f,0.4f,1f,] },
{ SymbolExtensions.Hi4, [0.2f,0.4f,1f,] },
{ SymbolExtensions.Low1, [0.1f,0.2f,0.5f,] },
{ SymbolExtensions.Low2, [0.1f,0.2f,0.5f,] },
{ SymbolExtensions.Low3, [0.1f,0.2f,0.5f,] },
{ SymbolExtensions.Low4, [0.1f,0.2f,0.5f,] },

                               },
                           EvaluationMode = EvaluationMode.WaysLeftToRight,
                           WildSymbol = SymbolExtensions.Wild,
                           GameMode = GameModeExtension.BaseSpin
                       },
                       boardWidth: 5,
                       boardHeight: 3)
},{
    GameModeExtension.FreeSpins7,
    new SpinGameModeRunner(new SpinMode
                       {
                           Evaluator = new SpinModeFreeSpins(GameModeExtension.FreeSpins7),
                           AllowedSymbols =
                           [
                               SymbolExtensions.Hi1,
SymbolExtensions.Hi2,
SymbolExtensions.Hi3,
SymbolExtensions.Hi4,
SymbolExtensions.Low1,
SymbolExtensions.Low2,
SymbolExtensions.Low3,
SymbolExtensions.Low4,

                           ],
                           AllowedTransitions = 
                           [
                               GameMode.None,

                           ],
                           Paytable =
                               new()
                               {
                                   { SymbolExtensions.Wild, [0.5f,1f,2.5f,] },
{ SymbolExtensions.Hi1, [0.5f,1f,2.5f,] },
{ SymbolExtensions.Hi2, [0.3f,0.6f,1.5f,] },
{ SymbolExtensions.Hi3, [0.2f,0.4f,1f,] },
{ SymbolExtensions.Hi4, [0.2f,0.4f,1f,] },
{ SymbolExtensions.Low1, [0.1f,0.2f,0.5f,] },
{ SymbolExtensions.Low2, [0.1f,0.2f,0.5f,] },
{ SymbolExtensions.Low3, [0.1f,0.2f,0.5f,] },
{ SymbolExtensions.Low4, [0.1f,0.2f,0.5f,] },

                               },
                           EvaluationMode = EvaluationMode.WaysLeftToRight,
                           WildSymbol = SymbolExtensions.Wild,
                           GameMode = GameModeExtension.FreeSpins7
                       },
                       boardWidth: 5,
                       boardHeight: 3)
},{
    GameModeExtension.FreeSpins9,
    new SpinGameModeRunner(new SpinMode
                       {
                           Evaluator = new SpinModeFreeSpins(GameModeExtension.FreeSpins9),
                           AllowedSymbols =
                           [
                               SymbolExtensions.Hi1,
SymbolExtensions.Hi2,
SymbolExtensions.Hi3,
SymbolExtensions.Hi4,
SymbolExtensions.Low1,
SymbolExtensions.Low2,
SymbolExtensions.Low3,
SymbolExtensions.Low4,

                           ],
                           AllowedTransitions = 
                           [
                               GameMode.None,

                           ],
                           Paytable =
                               new()
                               {
                                   { SymbolExtensions.Wild, [0.5f,1f,2.5f,] },
{ SymbolExtensions.Hi1, [0.5f,1f,2.5f,] },
{ SymbolExtensions.Hi2, [0.3f,0.6f,1.5f,] },
{ SymbolExtensions.Hi3, [0.2f,0.4f,1f,] },
{ SymbolExtensions.Hi4, [0.2f,0.4f,1f,] },
{ SymbolExtensions.Low1, [0.1f,0.2f,0.5f,] },
{ SymbolExtensions.Low2, [0.1f,0.2f,0.5f,] },
{ SymbolExtensions.Low3, [0.1f,0.2f,0.5f,] },
{ SymbolExtensions.Low4, [0.1f,0.2f,0.5f,] },

                               },
                           EvaluationMode = EvaluationMode.WaysLeftToRight,
                           WildSymbol = SymbolExtensions.Wild,
                           GameMode = GameModeExtension.FreeSpins9
                       },
                       boardWidth: 5,
                       boardHeight: 3)
},{
    GameModeExtension.FreeSpins11,
    new SpinGameModeRunner(new SpinMode
                       {
                           Evaluator = new SpinModeFreeSpins(GameModeExtension.FreeSpins11),
                           AllowedSymbols =
                           [
                               SymbolExtensions.Hi1,
SymbolExtensions.Hi2,
SymbolExtensions.Hi3,
SymbolExtensions.Hi4,
SymbolExtensions.Low1,
SymbolExtensions.Low2,
SymbolExtensions.Low3,
SymbolExtensions.Low4,

                           ],
                           AllowedTransitions = 
                           [
                               GameMode.None,

                           ],
                           Paytable =
                               new()
                               {
                                   { SymbolExtensions.Wild, [0.5f,1f,2.5f,] },
{ SymbolExtensions.Hi1, [0.5f,1f,2.5f,] },
{ SymbolExtensions.Hi2, [0.3f,0.6f,1.5f,] },
{ SymbolExtensions.Hi3, [0.2f,0.4f,1f,] },
{ SymbolExtensions.Hi4, [0.2f,0.4f,1f,] },
{ SymbolExtensions.Low1, [0.1f,0.2f,0.5f,] },
{ SymbolExtensions.Low2, [0.1f,0.2f,0.5f,] },
{ SymbolExtensions.Low3, [0.1f,0.2f,0.5f,] },
{ SymbolExtensions.Low4, [0.1f,0.2f,0.5f,] },

                               },
                           EvaluationMode = EvaluationMode.WaysLeftToRight,
                           WildSymbol = SymbolExtensions.Wild,
                           GameMode = GameModeExtension.FreeSpins11
                       },
                       boardWidth: 5,
                       boardHeight: 3)
},
        };
}
public static class FeatureExtension
{
    public static Feature Avalanche => new("Avalanche");

}
public static class GameModeExtension
{
    public static GameMode BaseSpin = new(GameModeType.Spin, "BaseSpin");
public static GameMode FreeSpins7 = new(GameModeType.Spin, "FreeSpins7");
public static GameMode FreeSpins9 = new(GameModeType.Spin, "FreeSpins9");
public static GameMode FreeSpins11 = new(GameModeType.Spin, "FreeSpins11");

}
public static class SymbolExtensions
{
    public static Symbol Hi1 = new("Hi1");
public static Symbol Hi2 = new("Hi2");
public static Symbol Hi3 = new("Hi3");
public static Symbol Hi4 = new("Hi4");
public static Symbol Low1 = new("Low1");
public static Symbol Low2 = new("Low2");
public static Symbol Low3 = new("Low3");
public static Symbol Low4 = new("Low4");
public static Symbol Scatter = new("Scatter");
public static Symbol Wild = new("Wild");

}
public class SpinModeBaseSpin : ISpinStepEvaluator
{
    private readonly GameMode _gameMode;

    public SpinModeBaseSpin(GameMode gameMode)
    {
        _gameMode = gameMode;
    }

    public GameMode GetNextMode(Step lastStep)
    {
        GameMode nextGameMode = GetNextModeInternal(lastStep);
        List<GameMode> allowedTransitions = new List<GameMode>
        {
            GameMode.None,
            GameModeExtension.FreeSpins7,
            GameModeExtension.FreeSpins9,
            GameModeExtension.FreeSpins11
        };
        if (!allowedTransitions.Contains(nextGameMode))
            throw new Exception($"Transition from BaseSpin to {nextGameMode} is not allowed");
        return nextGameMode;
    }

    public ISpinState GetInitialState()
    {
        return new BaseSpinState { Multiplier = 1f };
    }

    public Step EvaluateStep(Board board, ISpinState latestGameState, bool isInitialStep, List<CellCombination> baseWins)
    {
        var state = (BaseSpinState)latestGameState;
        float winAmount = 0f;
        foreach (var combo in baseWins)
        {
            winAmount += combo.CombinationPayout;
        }
        winAmount *= state.Multiplier;
        var stepType = isInitialStep ? StepType.InitialStep : StepType.Cascade;
        // update multiplier if any win occurred
        if (baseWins != null && baseWins.Count > 0)
        {
            state.Multiplier *= 2f;
        }
        var step = new Step(board.Clone())
        {
            WonCombinations = baseWins,
            StepWin = winAmount,
            StepType = stepType,
            SpinStateCopy = latestGameState.CloneState()
        };
        return step;
    }

    public bool ShouldHaveNextStep(IRng rng, Step step, ISpinState gameState)
    {
        return step.WonCombinations != null && step.WonCombinations.Count > 0;
    }

    public Board PrepareBoardForNextStep(IRng rng, Step lastStep, ISpinState gameState, List<Symbol> allowedSymbols)
    {
        var clonedBoard = lastStep.Board.Clone();
        return ApplyCascade(clonedBoard, lastStep.WonCombinations, allowedSymbols, rng);
    }

    public Dictionary<Feature, int> CountFeatureOccurrencesInStep(Step step)
    {
        var dict = new Dictionary<Feature, int>();
        if (step.StepType.Code == StepType.Cascade.Code && step.WonCombinations != null && step.WonCombinations.Count > 0)
        {
            dict.Add(FeatureExtension.Avalanche, 1);
        }
        return dict;
    }

    private GameMode GetNextModeInternal(Step lastStep)
    {
        // if cascade wins occurred, then we continue cascades until no win
        // when no win, check scatter count
        int scatterCount = 0;
        foreach (var reel in lastStep.Board.Reels)
        {
            foreach (var cell in reel.Cells)
            {
                if (cell.Symbol.SymbolCode == SymbolExtensions.Scatter.SymbolCode)
                    scatterCount++;
            }
        }
        if (scatterCount == 3)
            return GameModeExtension.FreeSpins7;
        if (scatterCount == 4)
            return GameModeExtension.FreeSpins9;
        if (scatterCount >= 5)
            return GameModeExtension.FreeSpins11;
        return GameMode.None;
    }

    private Board ApplyCascade(Board board, List<CellCombination> wins, List<Symbol> allowedSymbols, IRng rng)
    {
        // collect removed positions from wins
        var removedPositions = new HashSet<(int reelIndex, int y)>();
        if (wins != null)
        {
            foreach (var win in wins)
            {
                foreach (var pos in win.ActivatedCell)
                {
                    removedPositions.Add((pos.X, pos.Y));
                }
            }
        }

        // Process each reel
        for (int reelIndex = 0; reelIndex < board.Reels.Count; reelIndex++)
        {
            var reel = board.Reels[reelIndex];
            int totalCells = reel.Cells.Count;
            var nonRemoved = reel.Cells.Where(c => !removedPositions.Contains((reelIndex, c.Y))).ToList();
            int removedCount = totalCells - nonRemoved.Count;
            var newCells = new List<Cell>();
            // generate new random cells for removed count
            for (int i = 0; i < removedCount; i++)
            {
                var symbol = allowedSymbols[rng.Next(allowedSymbols.Count)];
                newCells.Add(new Cell { Y = i, Symbol = symbol });
            }
            // append the non removed cells, updating Y accordingly
            for (int i = 0; i < nonRemoved.Count; i++)
            {
                newCells.Add(new Cell { Y = removedCount + i, Symbol = nonRemoved[i].Symbol });
            }
            board.Reels[reelIndex].Cells = newCells;
        }
        // Place a wild symbol in one of the removed positions (choose first reel that had removals)
        for (int reelIndex = 0; reelIndex < board.Reels.Count; reelIndex++)
        {
            int originalCount = board.Height;
            var reel = board.Reels[reelIndex];
            if (reel.Cells.Count > 0 && reel.Cells.Count < originalCount)
                continue; // if no removal occurred, skip
            // Check if this reel had any removal by comparing new cells count with the number of new random cells generated
            // We assume removal occurred if the top cell is newly generated (we always generate removedCount new cells at top)
            // To decide, we check if the reel had any cell replaced due to removal.
            // We'll simply check if the first cell's Y is less than the number of cells in the reel that came from new generation by comparing with removed count.
            int removedCount = originalCount - board.Reels[reelIndex].Cells.SkipWhile(c => c.Y >= 0).Count(); // not used
            // Simpler: if the reel's first cell exists, we place wild in it if the reel had any removal originally by checking if any cell changed position.
            // For our implementation, we place wild in the reel if there is at least one cell and if removedPositions contained any cell with this reelIndex.
            bool hadRemoval = removedPositions.Any(rp => rp.reelIndex == reelIndex);
            if (hadRemoval)
            {
                // replace the top cell with wild
                reel.Cells[0] = new Cell { Y = reel.Cells[0].Y, Symbol = SymbolExtensions.Wild };
                break;
            }
        }
        return board;
    }
}

public record BaseSpinState : ISpinState
{
    public float Multiplier { get; set; }
    public ISpinState CloneState() => this with { };
}

public class SpinModeFreeSpins : ISpinStepEvaluator
{
    private readonly GameMode _gameMode;

    public SpinModeFreeSpins(GameMode gameMode)
    {
        _gameMode = gameMode;
    }

    public GameMode GetNextMode(Step lastStep)
    {
        return GameMode.None;
    }

    public ISpinState GetInitialState()
    {
        int spins = 0;
        if (_gameMode.Identifier.Contains("7"))
            spins = 7;
        else if (_gameMode.Identifier.Contains("9"))
            spins = 9;
        else if (_gameMode.Identifier.Contains("11"))
            spins = 11;
        return new FreeSpinsState { RemainingRespins = spins, Multiplier = 1f };
    }

    public Step EvaluateStep(Board board, ISpinState latestGameState, bool isInitialStep, List<CellCombination> baseWins)
    {
        var state = (FreeSpinsState)latestGameState;
        float winAmount = 0f;
        Step step;
        if (baseWins != null && baseWins.Count > 0)
        {
            foreach (var combo in baseWins)
            {
                winAmount += combo.CombinationPayout;
            }
            winAmount *= state.Multiplier;
            state.Multiplier *= 2f;
            step = new Step(board.Clone())
            {
                WonCombinations = baseWins,
                StepWin = winAmount,
                StepType = StepType.Cascade,
                SpinStateCopy = latestGameState.CloneState()
            };
        }
        else
        {
            // No cascade win, so this is a respin
            step = new Step(board.Clone())
            {
                WonCombinations = new List<CellCombination>(),
                StepWin = 0f,
                StepType = StepType.Respin,
                SpinStateCopy = latestGameState.CloneState()
            };
            state.RemainingRespins -= 1;
        }
        return step;
    }

    public bool ShouldHaveNextStep(IRng rng, Step step, ISpinState gameState)
    {
        var state = (FreeSpinsState)gameState;
        if (step.WonCombinations != null && step.WonCombinations.Count > 0)
            return true;
        return state.RemainingRespins > 0;
    }

    public Board PrepareBoardForNextStep(IRng rng, Step lastStep, ISpinState gameState, List<Symbol> allowedSymbols)
    {
        // If there was a cascade win, apply cascade mechanics; otherwise, generate a new board
        if (lastStep.WonCombinations != null && lastStep.WonCombinations.Count > 0)
        {
            var clonedBoard = lastStep.Board.Clone();
            return ApplyCascade(clonedBoard, lastStep.WonCombinations, allowedSymbols, rng);
        }
        else
        {
            // New respin board
            return BoardFunctions.GetRandomBoard(lastStep.Board.Width, lastStep.Board.Height, rng, allowedSymbols.ToArray());
        }
    }

    public Dictionary<Feature, int> CountFeatureOccurrencesInStep(Step step)
    {
        var dict = new Dictionary<Feature, int>();
        if (step.StepType.Code == StepType.Cascade.Code && step.WonCombinations != null && step.WonCombinations.Count > 0)
        {
            dict.Add(FeatureExtension.Avalanche, 1);
        }
        return dict;
    }

    private GameMode GetNextModeInternal(Step lastStep)
    {
        return GameMode.None;
    }

    private Board ApplyCascade(Board board, List<CellCombination> wins, List<Symbol> allowedSymbols, IRng rng)
    {
        var removedPositions = new HashSet<(int reelIndex, int y)>();
        if (wins != null)
        {
            foreach (var win in wins)
            {
                foreach (var pos in win.ActivatedCell)
                {
                    removedPositions.Add((pos.X, pos.Y));
                }
            }
        }
        for (int reelIndex = 0; reelIndex < board.Reels.Count; reelIndex++)
        {
            var reel = board.Reels[reelIndex];
            int totalCells = reel.Cells.Count;
            var nonRemoved = reel.Cells.Where(c => !removedPositions.Contains((reelIndex, c.Y))).ToList();
            int removedCount = totalCells - nonRemoved.Count;
            var newCells = new List<Cell>();
            for (int i = 0; i < removedCount; i++)
            {
                var symbol = allowedSymbols[rng.Next(allowedSymbols.Count)];
                newCells.Add(new Cell { Y = i, Symbol = symbol });
            }
            for (int i = 0; i < nonRemoved.Count; i++)
            {
                newCells.Add(new Cell { Y = removedCount + i, Symbol = nonRemoved[i].Symbol });
            }
            board.Reels[reelIndex].Cells = newCells;
        }
        for (int reelIndex = 0; reelIndex < board.Reels.Count; reelIndex++)
        {
            bool hadRemoval = removedPositions.Any(rp => rp.reelIndex == reelIndex);
            if (hadRemoval)
            {
                board.Reels[reelIndex].Cells[0] = new Cell { Y = board.Reels[reelIndex].Cells[0].Y, Symbol = SymbolExtensions.Wild };
                break;
            }
        }
        return board;
    }
}

public record FreeSpinsState : ISpinState
{
    public int RemainingRespins { get; set; }
    public float Multiplier { get; set; }
    public ISpinState CloneState() => this with { };
}

