
﻿using System;
using System.Text;
using Mathematics;

namespace csEquationSolver
{
    /// <summary>
    /// This class allows converting the status returned from the LinearEquationParser.Parse
    /// method.  This is done here to avoid having language-dependent resources used in the
    /// LinearEquationParser class.
    /// </summary>
    public static class LinearEquationParserStatusInterpreter
    {
        /// <summary>
        /// This method returns a status string corresponding to the passed
        /// status value returned from the LinearEquationParser.Parse method.
        /// </summary>
        /// <param name="status">An status value of type LinearEquationParserStatus</param>
        /// <returns>The string corresponding to the passed status code.</returns>
        public static string GetStatusString(LinearEquationParserStatus status)
        {
            string statusString = "";

            switch (status)
            {
                case LinearEquationParserStatus.Success:
                case LinearEquationParserStatus.SuccessNoEquation:
                    statusString = Properties.Resources.IDS_SUCCESS;
                    break;
                case LinearEquationParserStatus.ErrorIllegalEquation:
                    statusString = Properties.Resources.IDS_ERROR_ILLEGAL_EQUATION;
                    break;
                case LinearEquationParserStatus.ErrorNoEqualSign:
                    statusString = Properties.Resources.IDS_ERROR_NO_EQUAL_SIGN;
                    break;
                case LinearEquationParserStatus.ErrorMultipleEqualSigns:
                    statusString = Properties.Resources.IDS_ERROR_MULTIPLE_EQUAL_SIGNS;
                    break;
                case LinearEquationParserStatus.ErrorNoTermBeforeEqualSign:
                    statusString = Properties.Resources.IDS_ERROR_NO_TERM_BEFORE_EQUAL_SIGN;
                    break;
                case LinearEquationParserStatus.ErrorNoTermAfterEqualSign:
                    statusString = Properties.Resources.IDS_ERROR_NO_TERM_AFTER_EQUAL_SIGN;
                    break;
                case LinearEquationParserStatus.ErrorNoTermEncountered:
                    statusString = Properties.Resources.IDS_ERROR_NO_TERM_ENCOUNTERED;
                    break;
                case LinearEquationParserStatus.ErrorNoVariableInEquation:
                    statusString = Properties.Resources.IDS_ERROR_NO_VARIABLE_IN_EQUATION;
                    break;
                case LinearEquationParserStatus.ErrorMultipleDecimalPoints:
                    statusString = Properties.Resources.IDS_ERROR_MULTIPLE_DECIMAL_POINTS;
                    break;
                case LinearEquationParserStatus.ErrorTooManyDigits:
                    statusString = Properties.Resources.IDS_ERROR_TOO_MANY_DIGITS;
                    break;
                case LinearEquationParserStatus.ErrorMissingExponent:
                    statusString = Properties.Resources.IDS_ERROR_MISSING_EXPONENT;
                    break;
                case LinearEquationParserStatus.ErrorIllegalExponent:
                    statusString = Properties.Resources.IDS_ERROR_ILLEGAL_EXPONENT;
                    break;
                default:
                    statusString = Properties.Resources.IDS_ERROR_ILLEGAL_EQUATION;
                    break;
            }

            return statusString;
        }
    }
}
