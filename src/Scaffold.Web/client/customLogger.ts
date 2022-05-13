const { ILogger, LogLevel } = require("@microsoft/signalr");

export class CustomLogger implements InstanceType<typeof ILogger>  {
    log(logLevel: typeof LogLevel, message: string) {
        // Use `message` and `logLevel` to record the log message to your own system
        console.log(`${logLevel} :: ${message}`);
    }
}