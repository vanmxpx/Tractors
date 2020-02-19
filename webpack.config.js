const path = require('path');
const CompressionPlugin = require('compression-webpack-plugin');

module.exports = {
	entry: {
		components: './Content/components/expose-components.js',
	},
	output: {
		filename: '[name].js',
		globalObject: 'this',
		path: path.resolve(__dirname, 'wwwroot/dist'),
		publicPath: 'dist/'
	},
	mode: process.env.NODE_ENV === 'production' ? 'production' : 'development',
	optimization: {
		runtimeChunk: {
			name: 'runtime', // necessary when using multiple entrypoints on the same page
		},
		splitChunks: {
			cacheGroups: {
				commons: {
					test: /[\\/]node_modules[\\/](react|react-dom)[\\/]/,
					name: 'vendor',
					chunks: 'all',
				},
			},
		},
    },
    plugins: [
        new CompressionPlugin({
        filename: '[path].gz[query]',
        algorithm: 'gzip',
        test: /\.(js|css|html|svg)$/,
        threshold: 8192,
        minRatio: 0.8
        })
    ],
	module: {
		rules: [
			{
				test: /\.jsx?$/,
				exclude: /node_modules/,
				loader: 'babel-loader',
			},
		],
	},
};
