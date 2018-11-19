
export const dataService = {
    getJSON: function (url, cb) {
        fetch(url)
            .then(response => response.json())
            .then(data => {
                cb(data);
            });
        //const req = new XMLHttpRequest();
        //req.onload = function () {
        //    if (req.status === 404) {
        //        cb(new Error('not found'));
        //    } else {
        //        cb(null, JSON.parse(req.response));
        //    }
        //};
        //req.open('GET', url);
        ////req.setRequestHeader('authorization', localStorage.token);
        //req.send();
    },
    postJSON: function (url, obj, cb) {
        const req = new XMLHttpRequest();
        req.onload = function () {
            cb(JSON.parse(req.response));
        };
        req.open('POST', url);
        req.setRequestHeader('Content-Type', 'application/json;charset=UTF-8');
        //req.setRequestHeader('authorization', localStorage.token);
        req.send(JSON.stringify(obj));
    },
    deleteJSON: function (url, cb) {
        const req = new XMLHttpRequest();
        req.onload = cb;
        req.open('DELETE', url);
        //req.setRequestHeader('authorization', localStorage.token);
        req.send();
    }
};