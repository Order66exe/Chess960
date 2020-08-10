using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chess;
namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MainForm form = new MainForm();
            Assert.AreNotEqual(form.chess.Board.Kings[Player.WHITE], 0);
            Assert.AreNotEqual(form.chess.Board.Kings[Player.WHITE], 7);
            Assert.AreNotEqual(form.chess.Board.Kings[Player.BLACK], 0);
            Assert.AreNotEqual(form.chess.Board.Kings[Player.BLACK], 7);
        }
        [TestMethod]
        public void TestMethod2()
        {
            MainForm form = new MainForm();
            if(getPiecePos(form, 0, Piece.BISHOP)%2 == 0)
            {
                Assert.AreNotEqual(getPiecePos(form, getPiecePos(form, 0, Piece.BISHOP), Piece.BISHOP)%2, 0);
            }
            else if(getPiecePos(form, 0, Piece.BISHOP)%2 > 0)
            {
                Assert.AreEqual(getPiecePos(form, getPiecePos(form, 0, Piece.BISHOP), Piece.BISHOP) % 2, 0);
            }
        }
        [TestMethod]
        public void TestMethod3()
        {
            MainForm form = new MainForm();
            Assert.IsTrue(getPiecePos(form, 0, Piece.ROOK) < form.chess.Board.Kings[Player.WHITE].letter);
            Assert.IsTrue(getPiecePos(form, getPiecePos(form, 0, Piece.ROOK), Piece.ROOK) > form.chess.Board.Kings[Player.WHITE].letter);
            Assert.IsTrue(getPiecePos(form, 0, Piece.ROOK) < form.chess.Board.Kings[Player.BLACK].letter);
            Assert.IsTrue(getPiecePos(form, getPiecePos(form, 0, Piece.ROOK), Piece.ROOK) > form.chess.Board.Kings[Player.BLACK].letter);
        }
        [TestMethod]
        public void TestMethod4()
        {
            MainForm form = new MainForm();
            Assert.AreEqual(form.chess.Board.Pieces[Player.WHITE].Count, 16);
            Assert.AreEqual(form.chess.Board.Pieces[Player.BLACK].Count, 16);
        }
        [TestMethod]
        public void TestMethod5()
        {
            MainForm form = new MainForm();
            Assert.AreEqual(form.chess.Board.Grid[0][0].piece, form.chess.Board.Grid[0][7].piece);
            Assert.AreEqual(form.chess.Board.Grid[1][0].piece, form.chess.Board.Grid[1][7].piece);
            Assert.AreEqual(form.chess.Board.Grid[2][0].piece, form.chess.Board.Grid[2][7].piece);
            Assert.AreEqual(form.chess.Board.Grid[3][0].piece, form.chess.Board.Grid[3][7].piece);
            Assert.AreEqual(form.chess.Board.Grid[4][0].piece, form.chess.Board.Grid[4][7].piece);
            Assert.AreEqual(form.chess.Board.Grid[5][0].piece, form.chess.Board.Grid[5][7].piece);
            Assert.AreEqual(form.chess.Board.Grid[6][0].piece, form.chess.Board.Grid[6][7].piece);
            Assert.AreEqual(form.chess.Board.Grid[7][0].piece, form.chess.Board.Grid[7][7].piece);
        }
        public int getPiecePos(MainForm form, int startingPlace, Piece piece)
        {
            int result = 0;
            for (int i = startingPlace; i < 8; i++)
            {
                if (form.chess.Board.Grid[i][0].piece == piece)
                {
                    return i;
                }
            }
            return result;
        }
    }
}
