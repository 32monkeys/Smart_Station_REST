# Smart Station REST API Documentation

**Base URL:** `http://localhost:5143`

---

## Endpoints

### 1. GET All Journeys
```
GET /api/journeys
```
**Description:** Retrieve all journeys

**Response:** `200 OK`
```json
[
  {
    "id": 1,
    "startLocation": "Central Station",
    "destination": "Airport",
    "weekday": "Monday"
  }
]
```

---

### 2. GET Journey by ID
```
GET /api/journeys/{id}
```
**Description:** Retrieve a specific journey by ID

**Parameters:**
- `id` (integer, required): Journey ID

**Response:** `200 OK`
```json
{
  "id": 1,
  "startLocation": "Central Station",
  "destination": "Airport",
  "weekday": "Monday"
}
```

**Error Response:** `404 Not Found` - Journey not found

---

### 3. POST Create Journey
```
POST /api/journeys
Content-Type: application/json
```
**Description:** Create a new journey for a specific date

**Request Body:**
```json
{
  "startLocation": "Central Station",
  "destination": "Airport",
  "date": "2026-11-26"
}
```

**Response:** `201 Created`
```json
{
  "id": 1,
  "startLocation": "Central Station",
  "destination": "Airport",
  "date": "2026-11-26T00:00:00"
}
```

**Error Response:** `400 Bad Request` - Invalid input

---

### 4. PUT Update Journey
```
PUT /api/journeys/{id}
```
**Status:** ⚠️ Not Implemented

---

### 5. DELETE Journey
```
DELETE /api/journeys/{id}
```
**Status:** ⚠️ Not Implemented

---

## Journey Model

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| id | integer | - | Auto-generated ID |
| startLocation | string | Yes | Starting location |
| destination | string | Yes | Destination location |
| date | DateTime | Yes | Date of the journey (format: YYYY-MM-DD)

---

## Example Requests (cURL)

### Get all journeys
```bash
curl -X GET "http://localhost:5143/api/journeys"
```

### Get journey by ID
```bash
curl -X GET "http://localhost:5143/api/journeys/1"
```

### Create a new journey
```bash
curl -X POST "http://localhost:5143/api/journeys" \
  -H "Content-Type: application/json" \
  -d '{
    "startLocation": "Central Station",
    "destination": "Airport",
    "date": "2026-11-26"
  }'
```

---

## Example Requests (.http format)

```http
### Get all journeys
GET http://localhost:5143/api/journeys

### Get journey by ID
GET http://localhost:5143/api/journeys/1

### Create a new journey
POST http://localhost:5143/api/journeys
Content-Type: application/json

{
  "startLocation": "Central Station",
  "destination": "Airport",
  "date": "2026-11-26"
}
```
