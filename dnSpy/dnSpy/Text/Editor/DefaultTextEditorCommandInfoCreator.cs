﻿/*
    Copyright (C) 2014-2016 de4dot@gmail.com

    This file is part of dnSpy

    dnSpy is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    dnSpy is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with dnSpy.  If not, see <http://www.gnu.org/licenses/>.
*/

using System.Collections.Generic;
using System.Windows.Input;
using dnSpy.Contracts.Command;
using dnSpy.Contracts.Text.Editor;

namespace dnSpy.Text.Editor {
	[ExportCommandInfoCreator(CommandConstants.CMDINFO_ORDER_TEXT_EDITOR)]
	sealed class DefaultTextEditorCommandInfoCreator : ICommandInfoCreator {
		public IEnumerable<CommandShortcut> GetCommandShortcuts(object target) {
			if (!(target is ITextView))
				yield break;

			yield return CommandShortcut.Create(Key.Back, TextEditorIds.BACKSPACE.ToCommandInfo());
			//TODO: yield return CommandShortcut.Control(Key.XXXXX, TextEditorIds.BACKTAB.ToCommandInfo());
			//TODO: yield return CommandShortcut.Control(Key.XXXXX, TextEditorIds.BOL.ToCommandInfo());
			//TODO: yield return CommandShortcut.Control(Key.XXXXX, TextEditorIds.BOL_EXT.ToCommandInfo());
			//TODO: yield return CommandShortcut.Control(Key.XXXXX, TextEditorIds.BOL_EXT_COL.ToCommandInfo());
			yield return CommandShortcut.Control(Key.PageDown, TextEditorIds.BOTTOMLINE.ToCommandInfo());
			yield return CommandShortcut.CtrlShift(Key.PageDown, TextEditorIds.BOTTOMLINE_EXT.ToCommandInfo());
			yield return CommandShortcut.Create(Key.Escape, TextEditorIds.CANCEL.ToCommandInfo());
			//TODO: yield return CommandShortcut.Control(Key.XXXXX, TextEditorIds.CUTLINE.ToCommandInfo());
			yield return CommandShortcut.Create(Key.Delete, TextEditorIds.DELETE.ToCommandInfo());
			//TODO: yield return CommandShortcut.Control(Key.XXXXX, TextEditorIds.DELETEBLANKLINES.ToCommandInfo());
			//TODO: yield return CommandShortcut.Control(Key.XXXXX, TextEditorIds.DELETELINE.ToCommandInfo());
			//TODO: yield return CommandShortcut.Control(Key.XXXXX, TextEditorIds.DELETETOBOL.ToCommandInfo());
			//TODO: yield return CommandShortcut.Control(Key.XXXXX, TextEditorIds.DELETETOEOL.ToCommandInfo());
			//TODO: yield return CommandShortcut.Control(Key.XXXXX, TextEditorIds.DELETEWHITESPACE.ToCommandInfo());
			//TODO: yield return CommandShortcut.Control(Key.XXXXX, TextEditorIds.DELETEWORDLEFT.ToCommandInfo());
			//TODO: yield return CommandShortcut.Control(Key.XXXXX, TextEditorIds.DELETEWORDRIGHT.ToCommandInfo());
			yield return CommandShortcut.Create(Key.Down, TextEditorIds.DOWN.ToCommandInfo());
			yield return CommandShortcut.Shift(Key.Down, TextEditorIds.DOWN_EXT.ToCommandInfo());
			yield return CommandShortcut.ShiftAlt(Key.Down, TextEditorIds.DOWN_EXT_COL.ToCommandInfo());
			//TODO: yield return CommandShortcut.Control(Key.XXXXX, TextEditorIds.ECMD_CONVERTSPACESTOTABS.ToCommandInfo());
			//TODO: yield return CommandShortcut.Control(Key.XXXXX, TextEditorIds.ECMD_CONVERTTABSTOSPACES.ToCommandInfo());
			//TODO: yield return CommandShortcut.Control(Key.XXXXX, TextEditorIds.EditorLineFirstColumn.ToCommandInfo());
			//TODO: yield return CommandShortcut.Control(Key.XXXXX, TextEditorIds.EditorLineFirstColumnExtend.ToCommandInfo());
			yield return CommandShortcut.Control(Key.End, TextEditorIds.END.ToCommandInfo());
			yield return CommandShortcut.CtrlShift(Key.End, TextEditorIds.END_EXT.ToCommandInfo());
			yield return CommandShortcut.Create(Key.End, TextEditorIds.EOL.ToCommandInfo());
			yield return CommandShortcut.Shift(Key.End, TextEditorIds.EOL_EXT.ToCommandInfo());
			yield return CommandShortcut.ShiftAlt(Key.End, TextEditorIds.EOL_EXT_COL.ToCommandInfo());
			yield return CommandShortcut.Create(Key.Home, TextEditorIds.FIRSTCHAR.ToCommandInfo());
			yield return CommandShortcut.Shift(Key.Home, TextEditorIds.FIRSTCHAR_EXT.ToCommandInfo());
			//TODO: yield return CommandShortcut.Control(Key.XXXXX, TextEditorIds.FIRSTNONWHITENEXT.ToCommandInfo());
			//TODO: yield return CommandShortcut.Control(Key.XXXXX, TextEditorIds.FIRSTNONWHITEPREV.ToCommandInfo());
			//TODO: yield return CommandShortcut.Control(Key.XXXXX, TextEditorIds.GOTOBRACE.ToCommandInfo());
			//TODO: yield return CommandShortcut.Control(Key.XXXXX, TextEditorIds.GOTOBRACE_EXT.ToCommandInfo());
			yield return CommandShortcut.Control(Key.G, TextEditorIds.GOTOLINE.ToCommandInfo());
			yield return CommandShortcut.Control(Key.Home, TextEditorIds.HOME.ToCommandInfo());
			yield return CommandShortcut.CtrlShift(Key.Home, TextEditorIds.HOME_EXT.ToCommandInfo());
			//TODO: yield return CommandShortcut.Control(Key.XXXXX, TextEditorIds.INDENT.ToCommandInfo());
			//TODO: yield return CommandShortcut.Control(Key.XXXXX, TextEditorIds.LASTCHAR.ToCommandInfo());
			//TODO: yield return CommandShortcut.Control(Key.XXXXX, TextEditorIds.LASTCHAR_EXT.ToCommandInfo());
			yield return CommandShortcut.Create(Key.Left, TextEditorIds.LEFT.ToCommandInfo());
			yield return CommandShortcut.Shift(Key.Left, TextEditorIds.LEFT_EXT.ToCommandInfo());
			yield return CommandShortcut.ShiftAlt(Key.Left, TextEditorIds.LEFT_EXT_COL.ToCommandInfo());
			yield return CommandShortcut.Alt(Key.Down, TextEditorIds.MoveSelLinesDown.ToCommandInfo());
			yield return CommandShortcut.Alt(Key.Up, TextEditorIds.MoveSelLinesUp.ToCommandInfo());
			yield return CommandShortcut.Control(Key.Enter, TextEditorIds.OPENLINEABOVE.ToCommandInfo());
			yield return CommandShortcut.CtrlShift(Key.Enter, TextEditorIds.OPENLINEBELOW.ToCommandInfo());
			yield return CommandShortcut.Create(Key.PageDown, TextEditorIds.PAGEDN.ToCommandInfo());
			yield return CommandShortcut.Shift(Key.PageDown, TextEditorIds.PAGEDN_EXT.ToCommandInfo());
			yield return CommandShortcut.Create(Key.PageUp, TextEditorIds.PAGEUP.ToCommandInfo());
			yield return CommandShortcut.Shift(Key.PageUp, TextEditorIds.PAGEUP_EXT.ToCommandInfo());
			yield return CommandShortcut.Create(Key.Enter, TextEditorIds.RETURN.ToCommandInfo());
			yield return CommandShortcut.Create(Key.Right, TextEditorIds.RIGHT.ToCommandInfo());
			yield return CommandShortcut.Shift(Key.Right, TextEditorIds.RIGHT_EXT.ToCommandInfo());
			yield return CommandShortcut.ShiftAlt(Key.Right, TextEditorIds.RIGHT_EXT_COL.ToCommandInfo());
			//TODO: yield return CommandShortcut.Control(Key.XXXXX, TextEditorIds.SCROLLBOTTOM.ToCommandInfo());
			//TODO: yield return CommandShortcut.Control(Key.XXXXX, TextEditorIds.SCROLLCENTER.ToCommandInfo());
			yield return CommandShortcut.Control(Key.Down, TextEditorIds.SCROLLDN.ToCommandInfo());
			//TODO: yield return CommandShortcut.Control(Key.XXXXX, TextEditorIds.SCROLLLEFT.ToCommandInfo());
			//TODO: yield return CommandShortcut.Control(Key.XXXXX, TextEditorIds.SCROLLPAGEDN.ToCommandInfo());
			//TODO: yield return CommandShortcut.Control(Key.XXXXX, TextEditorIds.SCROLLPAGEUP.ToCommandInfo());
			//TODO: yield return CommandShortcut.Control(Key.XXXXX, TextEditorIds.SCROLLRIGHT.ToCommandInfo());
			//TODO: yield return CommandShortcut.Control(Key.XXXXX, TextEditorIds.SCROLLTOP.ToCommandInfo());
			yield return CommandShortcut.Control(Key.Up, TextEditorIds.SCROLLUP.ToCommandInfo());
			yield return CommandShortcut.Control(Key.A, TextEditorIds.SELECTALL.ToCommandInfo());
			yield return CommandShortcut.Control(Key.W, TextEditorIds.SELECTCURRENTWORD.ToCommandInfo());
			yield return CommandShortcut.Control(Key.U, TextEditorIds.SELLOWCASE.ToCommandInfo());
			//TODO: yield return CommandShortcut.Control(Key.XXXXX, TextEditorIds.SELSWAPANCHOR.ToCommandInfo());
			//TODO: yield return CommandShortcut.Control(Key.XXXXX, TextEditorIds.SELTABIFY.ToCommandInfo());
			//TODO: yield return CommandShortcut.Control(Key.XXXXX, TextEditorIds.SELTITLECASE.ToCommandInfo());
			//TODO: yield return CommandShortcut.Control(Key.XXXXX, TextEditorIds.SELTOGGLECASE.ToCommandInfo());
			//TODO: yield return CommandShortcut.Control(Key.XXXXX, TextEditorIds.SELTOGOBACK.ToCommandInfo());
			//TODO: yield return CommandShortcut.Control(Key.XXXXX, TextEditorIds.SELUNTABIFY.ToCommandInfo());
			yield return CommandShortcut.CtrlShift(Key.U, TextEditorIds.SELUPCASE.ToCommandInfo());
			//TODO: yield return CommandShortcut.Control(Key.XXXXX, TextEditorIds.SmartBreakLine.ToCommandInfo());
			yield return CommandShortcut.Create(Key.Tab, TextEditorIds.TAB.ToCommandInfo());
			yield return CommandShortcut.Create(Key.Insert, TextEditorIds.TOGGLE_OVERTYPE_MODE.ToCommandInfo());
			yield return CommandShortcut.CtrlShift(Key.D8, TextEditorIds.TOGGLEVISSPACE.ToCommandInfo());
			yield return CommandShortcut.Create(KeyInput.Control(Key.R), KeyInput.Control(Key.W), TextEditorIds.TOGGLEVISSPACE.ToCommandInfo());
			//TODO: yield return CommandShortcut.Control(Key.XXXXX, TextEditorIds.TOGGLEWORDWRAP.ToCommandInfo());
			yield return CommandShortcut.Control(Key.PageUp, TextEditorIds.TOPLINE.ToCommandInfo());
			yield return CommandShortcut.CtrlShift(Key.PageUp, TextEditorIds.TOPLINE_EXT.ToCommandInfo());
			//TODO: yield return CommandShortcut.Control(Key.XXXXX, TextEditorIds.TRANSPOSECHAR.ToCommandInfo());
			//TODO: yield return CommandShortcut.Control(Key.XXXXX, TextEditorIds.TRANSPOSELINE.ToCommandInfo());
			//TODO: yield return CommandShortcut.Control(Key.XXXXX, TextEditorIds.TRANSPOSEWORD.ToCommandInfo());
			//TODO: yield return CommandShortcut.Control(Key.XXXXX, TextEditorIds.TYPECHAR.ToCommandInfo());
			//TODO: yield return CommandShortcut.Control(Key.XXXXX, TextEditorIds.UNINDENT.ToCommandInfo());
			yield return CommandShortcut.Create(Key.Up, TextEditorIds.UP.ToCommandInfo());
			yield return CommandShortcut.Shift(Key.Up, TextEditorIds.UP_EXT.ToCommandInfo());
			yield return CommandShortcut.ShiftAlt(Key.Up, TextEditorIds.UP_EXT_COL.ToCommandInfo());
			yield return CommandShortcut.Control(Key.Right, TextEditorIds.WORDNEXT.ToCommandInfo());
			yield return CommandShortcut.CtrlShift(Key.Right, TextEditorIds.WORDNEXT_EXT.ToCommandInfo());
			yield return CommandShortcut.CtrlShiftAlt(Key.Right, TextEditorIds.WORDNEXT_EXT_COL.ToCommandInfo());
			yield return CommandShortcut.Control(Key.Left, TextEditorIds.WORDPREV.ToCommandInfo());
			yield return CommandShortcut.CtrlShift(Key.Left, TextEditorIds.WORDPREV_EXT.ToCommandInfo());
			yield return CommandShortcut.CtrlShiftAlt(Key.Left, TextEditorIds.WORDPREV_EXT_COL.ToCommandInfo());
			//TODO: yield return CommandShortcut.Control(Key.XXXXX, TextEditorIds.ZoomIn.ToCommandInfo());
			//TODO: yield return CommandShortcut.Control(Key.XXXXX, TextEditorIds.ZoomOut.ToCommandInfo());
		}

		public CommandInfo? CreateFromTextInput(object target, string text) => TextEditorIds.TYPECHAR.ToCommandInfo(text);
	}
}