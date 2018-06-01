/******/ (function(modules) { // webpackBootstrap
/******/ 	// The module cache
/******/ 	var installedModules = {};
/******/
/******/ 	// The require function
/******/ 	function __webpack_require__(moduleId) {
/******/
/******/ 		// Check if module is in cache
/******/ 		if(installedModules[moduleId]) {
/******/ 			return installedModules[moduleId].exports;
/******/ 		}
/******/ 		// Create a new module (and put it into the cache)
/******/ 		var module = installedModules[moduleId] = {
/******/ 			i: moduleId,
/******/ 			l: false,
/******/ 			exports: {}
/******/ 		};
/******/
/******/ 		// Execute the module function
/******/ 		modules[moduleId].call(module.exports, module, module.exports, __webpack_require__);
/******/
/******/ 		// Flag the module as loaded
/******/ 		module.l = true;
/******/
/******/ 		// Return the exports of the module
/******/ 		return module.exports;
/******/ 	}
/******/
/******/
/******/ 	// expose the modules object (__webpack_modules__)
/******/ 	__webpack_require__.m = modules;
/******/
/******/ 	// expose the module cache
/******/ 	__webpack_require__.c = installedModules;
/******/
/******/ 	// define getter function for harmony exports
/******/ 	__webpack_require__.d = function(exports, name, getter) {
/******/ 		if(!__webpack_require__.o(exports, name)) {
/******/ 			Object.defineProperty(exports, name, {
/******/ 				configurable: false,
/******/ 				enumerable: true,
/******/ 				get: getter
/******/ 			});
/******/ 		}
/******/ 	};
/******/
/******/ 	// getDefaultExport function for compatibility with non-harmony modules
/******/ 	__webpack_require__.n = function(module) {
/******/ 		var getter = module && module.__esModule ?
/******/ 			function getDefault() { return module['default']; } :
/******/ 			function getModuleExports() { return module; };
/******/ 		__webpack_require__.d(getter, 'a', getter);
/******/ 		return getter;
/******/ 	};
/******/
/******/ 	// Object.prototype.hasOwnProperty.call
/******/ 	__webpack_require__.o = function(object, property) { return Object.prototype.hasOwnProperty.call(object, property); };
/******/
/******/ 	// __webpack_public_path__
/******/ 	__webpack_require__.p = "";
/******/
/******/ 	// Load entry module and return exports
/******/ 	return __webpack_require__(__webpack_require__.s = 0);
/******/ })
/************************************************************************/
/******/ ([
/* 0 */
/***/ (function(module, exports, __webpack_require__) {

"use strict";

Object.defineProperty(exports, "__esModule", { value: true });
__webpack_require__(1);
var LogObject_1 = __webpack_require__(2);
;
var Blazor = window["Blazor"];
function initialize() {
    "use strict";
    Blazor.registerFunction('Blazor.Extensions.Logging.BrowserConsoleLogger.Log', function (logObjectValue) {
        var logObjectString = Blazor.platform.toJavaScriptString(logObjectValue);
        var logObject = JSON.parse(logObjectString);
        if (!logObject) {
            console.error('Invalid logObject received: ', logObjectString ? logObjectString : '<null>');
            return;
        }
        var logMethod = console.log;
        // If we've a table, we'll print it as a table anyway, it is unlikely that the developer want to log errornous data as a table.
        if (logObject.Type == LogObject_1.LogObjectType.Table) {
            logMethod = console.table;
        }
        else {
            switch (logObject.LogLevel) {
                case LogObject_1.LogLevel.Trace:
                    logMethod = console.trace;
                    break;
                case LogObject_1.LogLevel.Debug:
                    logMethod = console.debug;
                    break;
                case LogObject_1.LogLevel.Warning:
                    logMethod = console.warn;
                    break;
                case LogObject_1.LogLevel.Error:
                case LogObject_1.LogLevel.Critical:
                    logMethod = console.error;
                    break;
            }
        }
        logMethod(logObject.Payload);
        if (logObject.Exception) {
            logMethod("Exception: ", logObject.Exception);
        }
    });
}
initialize();


/***/ }),
/* 1 */
/***/ (function(module, exports, __webpack_require__) {

"use strict";

if (typeof window !== 'undefined' && !window['BlazorExtensions']) {
    // When the library is loaded in a browser via a <script> element, make the
    // following APIs available in global scope for invocation from JS
    window['BlazorExtensions'] = {};
}


/***/ }),
/* 2 */
/***/ (function(module, exports, __webpack_require__) {

"use strict";

Object.defineProperty(exports, "__esModule", { value: true });
// Enum coming from Microsoft.Extensions.Logging
var LogLevel;
(function (LogLevel) {
    LogLevel[LogLevel["Trace"] = 0] = "Trace";
    LogLevel[LogLevel["Debug"] = 1] = "Debug";
    LogLevel[LogLevel["Information"] = 2] = "Information";
    LogLevel[LogLevel["Warning"] = 3] = "Warning";
    LogLevel[LogLevel["Error"] = 4] = "Error";
    LogLevel[LogLevel["Critical"] = 5] = "Critical";
    LogLevel[LogLevel["None"] = 6] = "None";
})(LogLevel = exports.LogLevel || (exports.LogLevel = {}));
var LogObjectType;
(function (LogObjectType) {
    LogObjectType[LogObjectType["String"] = 0] = "String";
    LogObjectType[LogObjectType["Object"] = 1] = "Object";
    LogObjectType[LogObjectType["Table"] = 2] = "Table";
})(LogObjectType = exports.LogObjectType || (exports.LogObjectType = {}));


/***/ })
/******/ ]);
//# sourceMappingURL=data:application/json;charset=utf-8;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbIndlYnBhY2s6Ly8vd2VicGFjay9ib290c3RyYXAgODc5N2VhN2M1OGNlZTZiZWMzZjciLCJ3ZWJwYWNrOi8vLy4vc3JjL0luaXRpYWxpemUudHMiLCJ3ZWJwYWNrOi8vLy4vc3JjL0dsb2JhbEV4cG9ydHMudHMiLCJ3ZWJwYWNrOi8vLy4vc3JjL0xvZ09iamVjdC50cyJdLCJuYW1lcyI6W10sIm1hcHBpbmdzIjoiO0FBQUE7QUFDQTs7QUFFQTtBQUNBOztBQUVBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBOztBQUVBO0FBQ0E7O0FBRUE7QUFDQTs7QUFFQTtBQUNBO0FBQ0E7OztBQUdBO0FBQ0E7O0FBRUE7QUFDQTs7QUFFQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBLGFBQUs7QUFDTDtBQUNBOztBQUVBO0FBQ0E7QUFDQTtBQUNBLG1DQUEyQiwwQkFBMEIsRUFBRTtBQUN2RCx5Q0FBaUMsZUFBZTtBQUNoRDtBQUNBO0FBQ0E7O0FBRUE7QUFDQSw4REFBc0QsK0RBQStEOztBQUVySDtBQUNBOztBQUVBO0FBQ0E7Ozs7Ozs7Ozs7QUM3REEsdUJBQXlCO0FBQ3pCLHlDQUFpRTtBQUdNLENBQUM7QUFZeEUsSUFBTSxNQUFNLEdBQWUsTUFBTSxDQUFDLFFBQVEsQ0FBQyxDQUFDO0FBRzVDO0lBQ0UsWUFBWSxDQUFDO0lBRWIsTUFBTSxDQUFDLGdCQUFnQixDQUFDLG9EQUFvRCxFQUFFLFVBQVUsY0FBYztRQUNwRyxJQUFNLGVBQWUsR0FBRyxNQUFNLENBQUMsUUFBUSxDQUFDLGtCQUFrQixDQUFDLGNBQWMsQ0FBQyxDQUFDO1FBQzNFLElBQU0sU0FBUyxHQUFjLElBQUksQ0FBQyxLQUFLLENBQUMsZUFBZSxDQUFDLENBQUM7UUFFekQsRUFBRSxDQUFDLENBQUMsQ0FBQyxTQUFTLENBQUMsQ0FBQyxDQUFDO1lBQ2YsT0FBTyxDQUFDLEtBQUssQ0FBQyw4QkFBOEIsRUFBRSxlQUFlLENBQUMsQ0FBQyxDQUFDLGVBQWUsQ0FBQyxDQUFDLENBQUMsUUFBUSxDQUFDLENBQUM7WUFDNUYsTUFBTSxDQUFDO1FBQ1QsQ0FBQztRQUVELElBQUksU0FBUyxHQUFHLE9BQU8sQ0FBQyxHQUFHLENBQUM7UUFFNUIsK0hBQStIO1FBQy9ILEVBQUUsQ0FBQyxDQUFDLFNBQVMsQ0FBQyxJQUFJLElBQUkseUJBQWEsQ0FBQyxLQUFLLENBQUMsQ0FBQyxDQUFDO1lBQzFDLFNBQVMsR0FBRyxPQUFPLENBQUMsS0FBSyxDQUFDO1FBQzVCLENBQUM7UUFBQyxJQUFJLENBQUMsQ0FBQztZQUNOLE1BQU0sQ0FBQyxDQUFDLFNBQVMsQ0FBQyxRQUFRLENBQUMsQ0FBQyxDQUFDO2dCQUMzQixLQUFLLG9CQUFRLENBQUMsS0FBSztvQkFDakIsU0FBUyxHQUFHLE9BQU8sQ0FBQyxLQUFLLENBQUM7b0JBQzFCLEtBQUssQ0FBQztnQkFDUixLQUFLLG9CQUFRLENBQUMsS0FBSztvQkFDakIsU0FBUyxHQUFHLE9BQU8sQ0FBQyxLQUFLLENBQUM7b0JBQzFCLEtBQUssQ0FBQztnQkFDUixLQUFLLG9CQUFRLENBQUMsT0FBTztvQkFDbkIsU0FBUyxHQUFHLE9BQU8sQ0FBQyxJQUFJLENBQUM7b0JBQ3pCLEtBQUssQ0FBQztnQkFDUixLQUFLLG9CQUFRLENBQUMsS0FBSyxDQUFDO2dCQUNwQixLQUFLLG9CQUFRLENBQUMsUUFBUTtvQkFDcEIsU0FBUyxHQUFHLE9BQU8sQ0FBQyxLQUFLLENBQUM7b0JBQzFCLEtBQUssQ0FBQztZQUNWLENBQUM7UUFDSCxDQUFDO1FBRUQsU0FBUyxDQUFDLFNBQVMsQ0FBQyxPQUFPLENBQUMsQ0FBQztRQUU3QixFQUFFLENBQUMsQ0FBQyxTQUFTLENBQUMsU0FBUyxDQUFDLENBQUMsQ0FBQztZQUN4QixTQUFTLENBQUMsYUFBYSxFQUFFLFNBQVMsQ0FBQyxTQUFTLENBQUMsQ0FBQztRQUNoRCxDQUFDO0lBQ0gsQ0FBQyxDQUFDLENBQUM7QUFDTCxDQUFDO0FBRUQsVUFBVSxFQUFFLENBQUM7Ozs7Ozs7OztBQzlEYixFQUFFLENBQUMsQ0FBQyxPQUFPLE1BQU0sS0FBSyxXQUFXLElBQUksQ0FBQyxNQUFNLENBQUMsa0JBQWtCLENBQUMsQ0FBQyxDQUFDLENBQUM7SUFDakUsMkVBQTJFO0lBQzNFLGtFQUFrRTtJQUNsRSxNQUFNLENBQUMsa0JBQWtCLENBQUMsR0FBRyxFQUM1QixDQUFDO0FBQ0osQ0FBQzs7Ozs7Ozs7OztBQ0VELGdEQUFnRDtBQUNoRCxJQUFZLFFBUVg7QUFSRCxXQUFZLFFBQVE7SUFDbEIseUNBQVM7SUFDVCx5Q0FBUztJQUNULHFEQUFlO0lBQ2YsNkNBQVc7SUFDWCx5Q0FBUztJQUNULCtDQUFZO0lBQ1osdUNBQVE7QUFDVixDQUFDLEVBUlcsUUFBUSxHQUFSLGdCQUFRLEtBQVIsZ0JBQVEsUUFRbkI7QUFFRCxJQUFZLGFBSVg7QUFKRCxXQUFZLGFBQWE7SUFDdkIscURBQVU7SUFDVixxREFBVTtJQUNWLG1EQUFTO0FBQ1gsQ0FBQyxFQUpXLGFBQWEsR0FBYixxQkFBYSxLQUFiLHFCQUFhLFFBSXhCIiwiZmlsZSI6ImJsYXpvci5leHRlbnNpb25zLmxvZ2dpbmcuanMiLCJzb3VyY2VzQ29udGVudCI6WyIgXHQvLyBUaGUgbW9kdWxlIGNhY2hlXG4gXHR2YXIgaW5zdGFsbGVkTW9kdWxlcyA9IHt9O1xuXG4gXHQvLyBUaGUgcmVxdWlyZSBmdW5jdGlvblxuIFx0ZnVuY3Rpb24gX193ZWJwYWNrX3JlcXVpcmVfXyhtb2R1bGVJZCkge1xuXG4gXHRcdC8vIENoZWNrIGlmIG1vZHVsZSBpcyBpbiBjYWNoZVxuIFx0XHRpZihpbnN0YWxsZWRNb2R1bGVzW21vZHVsZUlkXSkge1xuIFx0XHRcdHJldHVybiBpbnN0YWxsZWRNb2R1bGVzW21vZHVsZUlkXS5leHBvcnRzO1xuIFx0XHR9XG4gXHRcdC8vIENyZWF0ZSBhIG5ldyBtb2R1bGUgKGFuZCBwdXQgaXQgaW50byB0aGUgY2FjaGUpXG4gXHRcdHZhciBtb2R1bGUgPSBpbnN0YWxsZWRNb2R1bGVzW21vZHVsZUlkXSA9IHtcbiBcdFx0XHRpOiBtb2R1bGVJZCxcbiBcdFx0XHRsOiBmYWxzZSxcbiBcdFx0XHRleHBvcnRzOiB7fVxuIFx0XHR9O1xuXG4gXHRcdC8vIEV4ZWN1dGUgdGhlIG1vZHVsZSBmdW5jdGlvblxuIFx0XHRtb2R1bGVzW21vZHVsZUlkXS5jYWxsKG1vZHVsZS5leHBvcnRzLCBtb2R1bGUsIG1vZHVsZS5leHBvcnRzLCBfX3dlYnBhY2tfcmVxdWlyZV9fKTtcblxuIFx0XHQvLyBGbGFnIHRoZSBtb2R1bGUgYXMgbG9hZGVkXG4gXHRcdG1vZHVsZS5sID0gdHJ1ZTtcblxuIFx0XHQvLyBSZXR1cm4gdGhlIGV4cG9ydHMgb2YgdGhlIG1vZHVsZVxuIFx0XHRyZXR1cm4gbW9kdWxlLmV4cG9ydHM7XG4gXHR9XG5cblxuIFx0Ly8gZXhwb3NlIHRoZSBtb2R1bGVzIG9iamVjdCAoX193ZWJwYWNrX21vZHVsZXNfXylcbiBcdF9fd2VicGFja19yZXF1aXJlX18ubSA9IG1vZHVsZXM7XG5cbiBcdC8vIGV4cG9zZSB0aGUgbW9kdWxlIGNhY2hlXG4gXHRfX3dlYnBhY2tfcmVxdWlyZV9fLmMgPSBpbnN0YWxsZWRNb2R1bGVzO1xuXG4gXHQvLyBkZWZpbmUgZ2V0dGVyIGZ1bmN0aW9uIGZvciBoYXJtb255IGV4cG9ydHNcbiBcdF9fd2VicGFja19yZXF1aXJlX18uZCA9IGZ1bmN0aW9uKGV4cG9ydHMsIG5hbWUsIGdldHRlcikge1xuIFx0XHRpZighX193ZWJwYWNrX3JlcXVpcmVfXy5vKGV4cG9ydHMsIG5hbWUpKSB7XG4gXHRcdFx0T2JqZWN0LmRlZmluZVByb3BlcnR5KGV4cG9ydHMsIG5hbWUsIHtcbiBcdFx0XHRcdGNvbmZpZ3VyYWJsZTogZmFsc2UsXG4gXHRcdFx0XHRlbnVtZXJhYmxlOiB0cnVlLFxuIFx0XHRcdFx0Z2V0OiBnZXR0ZXJcbiBcdFx0XHR9KTtcbiBcdFx0fVxuIFx0fTtcblxuIFx0Ly8gZ2V0RGVmYXVsdEV4cG9ydCBmdW5jdGlvbiBmb3IgY29tcGF0aWJpbGl0eSB3aXRoIG5vbi1oYXJtb255IG1vZHVsZXNcbiBcdF9fd2VicGFja19yZXF1aXJlX18ubiA9IGZ1bmN0aW9uKG1vZHVsZSkge1xuIFx0XHR2YXIgZ2V0dGVyID0gbW9kdWxlICYmIG1vZHVsZS5fX2VzTW9kdWxlID9cbiBcdFx0XHRmdW5jdGlvbiBnZXREZWZhdWx0KCkgeyByZXR1cm4gbW9kdWxlWydkZWZhdWx0J107IH0gOlxuIFx0XHRcdGZ1bmN0aW9uIGdldE1vZHVsZUV4cG9ydHMoKSB7IHJldHVybiBtb2R1bGU7IH07XG4gXHRcdF9fd2VicGFja19yZXF1aXJlX18uZChnZXR0ZXIsICdhJywgZ2V0dGVyKTtcbiBcdFx0cmV0dXJuIGdldHRlcjtcbiBcdH07XG5cbiBcdC8vIE9iamVjdC5wcm90b3R5cGUuaGFzT3duUHJvcGVydHkuY2FsbFxuIFx0X193ZWJwYWNrX3JlcXVpcmVfXy5vID0gZnVuY3Rpb24ob2JqZWN0LCBwcm9wZXJ0eSkgeyByZXR1cm4gT2JqZWN0LnByb3RvdHlwZS5oYXNPd25Qcm9wZXJ0eS5jYWxsKG9iamVjdCwgcHJvcGVydHkpOyB9O1xuXG4gXHQvLyBfX3dlYnBhY2tfcHVibGljX3BhdGhfX1xuIFx0X193ZWJwYWNrX3JlcXVpcmVfXy5wID0gXCJcIjtcblxuIFx0Ly8gTG9hZCBlbnRyeSBtb2R1bGUgYW5kIHJldHVybiBleHBvcnRzXG4gXHRyZXR1cm4gX193ZWJwYWNrX3JlcXVpcmVfXyhfX3dlYnBhY2tfcmVxdWlyZV9fLnMgPSAwKTtcblxuXG5cbi8vIFdFQlBBQ0sgRk9PVEVSIC8vXG4vLyB3ZWJwYWNrL2Jvb3RzdHJhcCA4Nzk3ZWE3YzU4Y2VlNmJlYzNmNyIsImltcG9ydCAnLi9HbG9iYWxFeHBvcnRzJztcclxuaW1wb3J0IHsgTG9nT2JqZWN0LCBMb2dPYmplY3RUeXBlLCBMb2dMZXZlbCB9IGZyb20gJy4vTG9nT2JqZWN0JztcclxuXHJcbi8vIERlY2xhcmUgdHlwZXMgaGVyZSB1bnRpbCB3ZSd2ZSBCbGF6b3IuZC50c1xyXG5leHBvcnQgaW50ZXJmYWNlIFN5c3RlbV9PYmplY3QgeyBTeXN0ZW1fT2JqZWN0X19ET19OT1RfSU1QTEVNRU5UOiBhbnkgfTtcclxuZXhwb3J0IGludGVyZmFjZSBTeXN0ZW1fU3RyaW5nIGV4dGVuZHMgU3lzdGVtX09iamVjdCB7IFN5c3RlbV9TdHJpbmdfX0RPX05PVF9JTVBMRU1FTlQ6IGFueSB9XHJcblxyXG5pbnRlcmZhY2UgUGxhdGZvcm0ge1xyXG4gIHRvSmF2YVNjcmlwdFN0cmluZyhkb3ROZXRTdHJpbmc6IFN5c3RlbV9TdHJpbmcpOiBzdHJpbmc7XHJcbn1cclxuXHJcbnR5cGUgQmxhem9yVHlwZSA9IHtcclxuICByZWdpc3RlckZ1bmN0aW9uKGlkZW50aWZpZXI6IHN0cmluZywgaW1wbGVtZW50YXRpb246IEZ1bmN0aW9uKSxcclxuICBwbGF0Zm9ybTogUGxhdGZvcm1cclxufTtcclxuXHJcbmNvbnN0IEJsYXpvcjogQmxhem9yVHlwZSA9IHdpbmRvd1tcIkJsYXpvclwiXTtcclxuXHJcblxyXG5mdW5jdGlvbiBpbml0aWFsaXplKCkge1xyXG4gIFwidXNlIHN0cmljdFwiO1xyXG5cclxuICBCbGF6b3IucmVnaXN0ZXJGdW5jdGlvbignQmxhem9yLkV4dGVuc2lvbnMuTG9nZ2luZy5Ccm93c2VyQ29uc29sZUxvZ2dlci5Mb2cnLCBmdW5jdGlvbiAobG9nT2JqZWN0VmFsdWUpIHtcclxuICAgIGNvbnN0IGxvZ09iamVjdFN0cmluZyA9IEJsYXpvci5wbGF0Zm9ybS50b0phdmFTY3JpcHRTdHJpbmcobG9nT2JqZWN0VmFsdWUpO1xyXG4gICAgY29uc3QgbG9nT2JqZWN0OiBMb2dPYmplY3QgPSBKU09OLnBhcnNlKGxvZ09iamVjdFN0cmluZyk7XHJcblxyXG4gICAgaWYgKCFsb2dPYmplY3QpIHtcclxuICAgICAgY29uc29sZS5lcnJvcignSW52YWxpZCBsb2dPYmplY3QgcmVjZWl2ZWQ6ICcsIGxvZ09iamVjdFN0cmluZyA/IGxvZ09iamVjdFN0cmluZyA6ICc8bnVsbD4nKTtcclxuICAgICAgcmV0dXJuO1xyXG4gICAgfVxyXG5cclxuICAgIHZhciBsb2dNZXRob2QgPSBjb25zb2xlLmxvZztcclxuXHJcbiAgICAvLyBJZiB3ZSd2ZSBhIHRhYmxlLCB3ZSdsbCBwcmludCBpdCBhcyBhIHRhYmxlIGFueXdheSwgaXQgaXMgdW5saWtlbHkgdGhhdCB0aGUgZGV2ZWxvcGVyIHdhbnQgdG8gbG9nIGVycm9ybm91cyBkYXRhIGFzIGEgdGFibGUuXHJcbiAgICBpZiAobG9nT2JqZWN0LlR5cGUgPT0gTG9nT2JqZWN0VHlwZS5UYWJsZSkge1xyXG4gICAgICBsb2dNZXRob2QgPSBjb25zb2xlLnRhYmxlO1xyXG4gICAgfSBlbHNlIHtcclxuICAgICAgc3dpdGNoIChsb2dPYmplY3QuTG9nTGV2ZWwpIHtcclxuICAgICAgICBjYXNlIExvZ0xldmVsLlRyYWNlOlxyXG4gICAgICAgICAgbG9nTWV0aG9kID0gY29uc29sZS50cmFjZTtcclxuICAgICAgICAgIGJyZWFrO1xyXG4gICAgICAgIGNhc2UgTG9nTGV2ZWwuRGVidWc6XHJcbiAgICAgICAgICBsb2dNZXRob2QgPSBjb25zb2xlLmRlYnVnO1xyXG4gICAgICAgICAgYnJlYWs7XHJcbiAgICAgICAgY2FzZSBMb2dMZXZlbC5XYXJuaW5nOlxyXG4gICAgICAgICAgbG9nTWV0aG9kID0gY29uc29sZS53YXJuO1xyXG4gICAgICAgICAgYnJlYWs7XHJcbiAgICAgICAgY2FzZSBMb2dMZXZlbC5FcnJvcjpcclxuICAgICAgICBjYXNlIExvZ0xldmVsLkNyaXRpY2FsOlxyXG4gICAgICAgICAgbG9nTWV0aG9kID0gY29uc29sZS5lcnJvcjtcclxuICAgICAgICAgIGJyZWFrO1xyXG4gICAgICB9XHJcbiAgICB9XHJcblxyXG4gICAgbG9nTWV0aG9kKGxvZ09iamVjdC5QYXlsb2FkKTtcclxuXHJcbiAgICBpZiAobG9nT2JqZWN0LkV4Y2VwdGlvbikge1xyXG4gICAgICBsb2dNZXRob2QoXCJFeGNlcHRpb246IFwiLCBsb2dPYmplY3QuRXhjZXB0aW9uKTtcclxuICAgIH1cclxuICB9KTtcclxufVxyXG5cclxuaW5pdGlhbGl6ZSgpO1xyXG5cblxuXG4vLyBXRUJQQUNLIEZPT1RFUiAvL1xuLy8gLi9zcmMvSW5pdGlhbGl6ZS50cyIsImlmICh0eXBlb2Ygd2luZG93ICE9PSAndW5kZWZpbmVkJyAmJiAhd2luZG93WydCbGF6b3JFeHRlbnNpb25zJ10pIHtcclxuICAvLyBXaGVuIHRoZSBsaWJyYXJ5IGlzIGxvYWRlZCBpbiBhIGJyb3dzZXIgdmlhIGEgPHNjcmlwdD4gZWxlbWVudCwgbWFrZSB0aGVcclxuICAvLyBmb2xsb3dpbmcgQVBJcyBhdmFpbGFibGUgaW4gZ2xvYmFsIHNjb3BlIGZvciBpbnZvY2F0aW9uIGZyb20gSlNcclxuICB3aW5kb3dbJ0JsYXpvckV4dGVuc2lvbnMnXSA9IHtcclxuICB9O1xyXG59XHJcblxuXG5cbi8vIFdFQlBBQ0sgRk9PVEVSIC8vXG4vLyAuL3NyYy9HbG9iYWxFeHBvcnRzLnRzIiwiZXhwb3J0IHR5cGUgTG9nT2JqZWN0ID0ge1xyXG4gIExvZ0xldmVsOiBMb2dMZXZlbDtcclxuICBUeXBlOiBMb2dPYmplY3RUeXBlO1xyXG4gIFBheWxvYWQ6IGFueTtcclxuICBFeGNlcHRpb246IHN0cmluZztcclxufVxyXG5cclxuLy8gRW51bSBjb21pbmcgZnJvbSBNaWNyb3NvZnQuRXh0ZW5zaW9ucy5Mb2dnaW5nXHJcbmV4cG9ydCBlbnVtIExvZ0xldmVsIHtcclxuICBUcmFjZSA9IDAsXHJcbiAgRGVidWcgPSAxLFxyXG4gIEluZm9ybWF0aW9uID0gMixcclxuICBXYXJuaW5nID0gMyxcclxuICBFcnJvciA9IDQsXHJcbiAgQ3JpdGljYWwgPSA1LFxyXG4gIE5vbmUgPSA2XHJcbn1cclxuXHJcbmV4cG9ydCBlbnVtIExvZ09iamVjdFR5cGUge1xyXG4gIFN0cmluZyA9IDAsXHJcbiAgT2JqZWN0ID0gMSxcclxuICBUYWJsZSA9IDJcclxufVxyXG5cblxuXG4vLyBXRUJQQUNLIEZPT1RFUiAvL1xuLy8gLi9zcmMvTG9nT2JqZWN0LnRzIl0sInNvdXJjZVJvb3QiOiIifQ==