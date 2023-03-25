import { format, config, createLogger, transports } from "winston";
import winstonGelf from 'winston-gelf'
import process from 'process'

const logger = createLogger({
	level: "debug",
	levels: config.syslog.levels,
	transports: [
		new transports.Console(),
		new winstonGelf({
			gelfPro: {
				fields: {
					env: process.env.NODE_ENV || 'development',
					Application: "nodejs-console",
				},
				adapterName: 'tcp',
				adapterOptions: {
					host: '127.0.0.1',
					port: 12201,
				}
			}
		})
	],
	// format: format.combine(
	// 	format.colorize(),
	// 	format.json()
	// ),
});

logger.debug("nodejs console - debug")
logger.info("nodejs console - info")
logger.warning("nodejs console - warning")
logger.error("nodejs console - error")