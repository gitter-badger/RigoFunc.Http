// Copyright (c) RigoFunc (xuyingting). All rights reserved.

using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace System.Net.Http {
    /// <summary>
    /// Represents the extensions for <see cref="HttpClient"/>.
    /// </summary>
    public static class HttpClientExtensions {
        private static MediaTypeWithQualityHeaderValue _mime;

        static HttpClientExtensions() {
            _mime = new MediaTypeWithQualityHeaderValue("application/json");
        }

        /// <summary>
        /// Posts as json asynchronous.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="client">The client.</param>
        /// <param name="requestUri">The request URI.</param>
        /// <param name="value">The value.</param>
        /// <returns>A <see cref="Task{TResult}"/> represents the post operation.</returns>
        public async static Task<HttpResponseMessage> PostAsJsonAsync<T>(this HttpClient client, string requestUri, T value) {
            client.DefaultRequestHeaders.Accept.Add(_mime);

            return await client.PostAsync(requestUri, value.ToHttpContent());
        }

        /// <summary>
        /// Posts as json asynchronous.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="client">The client.</param>
        /// <param name="requestUri">The request URI.</param>
        /// <param name="value">The value.</param>
        /// <returns>A <see cref="Task{TResult}"/> represents the post operation.</returns>
        public async static Task<HttpResponseMessage> PostAsJsonAsync<T>(this HttpClient client, Uri requestUri, T value) {
            client.DefaultRequestHeaders.Accept.Add(_mime);

            return await client.PostAsync(requestUri, value.ToHttpContent());
        }
        /// <summary>
        /// Posts as json asynchronous.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="client">The client.</param>
        /// <param name="requestUri">The request URI.</param>
        /// <param name="value">The value.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A <see cref="Task{TResult}"/> represents the post operation.</returns>
        public async static Task<HttpResponseMessage> PostAsJsonAsync<T>(this HttpClient client, string requestUri, T value, CancellationToken cancellationToken) {
            client.DefaultRequestHeaders.Accept.Add(_mime);

            return await client.PostAsync(requestUri, value.ToHttpContent(), cancellationToken);
        }

        /// <summary>
        /// Posts as json asynchronous.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="client">The client.</param>
        /// <param name="requestUri">The request URI.</param>
        /// <param name="value">The value.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A <see cref="Task{TResult}"/> represents the post operation.</returns>
        public async static Task<HttpResponseMessage> PostAsJsonAsync<T>(this HttpClient client, Uri requestUri, T value, CancellationToken cancellationToken) {
            client.DefaultRequestHeaders.Accept.Add(_mime);

            return await client.PostAsync(requestUri, value.ToHttpContent(), cancellationToken);
        }

        /// <summary>
        /// Puts as json asynchronous.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="client">The client.</param>
        /// <param name="requestUri">The request URI.</param>
        /// <param name="value">The value.</param>
        /// <returns>A <see cref="Task{TResult}"/> represents the put operation.</returns>
        public async static Task<HttpResponseMessage> PutAsJsonAsync<T>(this HttpClient client, string requestUri, T value) {
            client.DefaultRequestHeaders.Accept.Add(_mime);

            return await client.PutAsync(requestUri, value.ToHttpContent());
        }

        /// <summary>
        /// Puts as json asynchronous.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="client">The client.</param>
        /// <param name="requestUri">The request URI.</param>
        /// <param name="value">The value.</param>
        /// <returns>A <see cref="Task{TResult}"/> represents the put operation.</returns>
        public async static Task<HttpResponseMessage> PutAsJsonAsync<T>(this HttpClient client, Uri requestUri, T value) {
            client.DefaultRequestHeaders.Accept.Add(_mime);

            return await client.PutAsync(requestUri, value.ToHttpContent());
        }

        /// <summary>
        /// Puts as json asynchronous.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="client">The client.</param>
        /// <param name="requestUri">The request URI.</param>
        /// <param name="value">The value.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A <see cref="Task{TResult}"/> represents the put operation.</returns>
        public async static Task<HttpResponseMessage> PutAsJsonAsync<T>(this HttpClient client, string requestUri, T value, CancellationToken cancellationToken) {
            client.DefaultRequestHeaders.Accept.Add(_mime);

            return await client.PutAsync(requestUri, value.ToHttpContent(), cancellationToken);
        }

        /// <summary>
        /// Puts as json asynchronous.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="client">The client.</param>
        /// <param name="requestUri">The request URI.</param>
        /// <param name="value">The value.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A <see cref="Task{TResult}"/> represents the put operation.</returns>
        public async static Task<HttpResponseMessage> PutAsJsonAsync<T>(this HttpClient client, Uri requestUri, T value, CancellationToken cancellationToken) {
            client.DefaultRequestHeaders.Accept.Add(_mime);

            return await client.PutAsync(requestUri, value.ToHttpContent(), cancellationToken);
        }

        internal static HttpContent ToHttpContent<T>(this T value) => new StringContent(JsonConvert.SerializeObject(value), Encoding.UTF8, "application/json");
    }
}
